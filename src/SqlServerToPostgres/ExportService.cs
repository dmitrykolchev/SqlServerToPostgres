using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace SqlServerToPostgres;


public class ExportService : IOperationsService
{
    private ConnectionService? _source;
    private ConnectionService? _destination;
    private InformationSchemaService? _sourceIss;
    private InformationSchemaService? _destinationIss;

    public ExportService(IOptions<ApplicationOptions> options, IServiceProvider serviceProvider)
    {
        ApplicationOptions = options.Value;
        ServiceProvider = serviceProvider;
    }

    public ApplicationOptions ApplicationOptions { get; set; }
    private IServiceProvider ServiceProvider { get; }

    private ConnectionService Source =>
        _source ??= ServiceProvider.GetRequiredKeyedService<ConnectionService>(Program.SourceKey);

    private ConnectionService Destination =>
        _destination ??= ServiceProvider.GetRequiredKeyedService<ConnectionService>(Program.DestinationKey);

    private InformationSchemaService SourceIss =>
        _sourceIss ??= ServiceProvider.GetRequiredKeyedService<InformationSchemaService>(Program.SourceKey);

    private InformationSchemaService DestinationIss =>
        _destinationIss ??= ServiceProvider.GetRequiredKeyedService<InformationSchemaService>(Program.DestinationKey);

    public async Task RunAsync()
    {
        if (ApplicationOptions.Exports is not null)
        {
            foreach (var export in ApplicationOptions.Exports)
            {
                if (export.DestinationTable is not null)
                {
                    Console.WriteLine($"Starting export {export.SourceTable ?? export.SourceQuery} -> {export.DestinationTable}");
                    await ExportTableAsync(export);
                }
                else
                {
                    Console.WriteLine($"Source {export.SourceTable ?? export.SourceQuery} skipped. Destination has not been set.");
                }
            }
        }
        else
        {
            Console.WriteLine("Nothing to export");
        }
    }

    private Task ExportQueryAsync(TableExportOptions export)
    {
        return Task.CompletedTask;
    }

    private async Task ExportTableAsync(TableExportOptions export)
    {
        List<ExportColumnMapping> mappings = CreateColumnMappings(export);
        string sourceColumnList = string.Join(", ", mappings.Where(t => t.Source != null).Select(t => t.Source));

        DbConnection connection = Source.CreateConnection();
        await connection.OpenAsync();
        DataTable destination = CreateDataTable(export, mappings);
        string baseQuery = CreateBaseQuery(export, sourceColumnList);

        int offset = 0;
        int totalCount = 0;
        for (; ; )
        {
            string sql = $@"{baseQuery} OFFSET {offset} ROWS FETCH NEXT {export.BatchSize} ROWS ONLY";
            using DbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.CommandTimeout = export.CommandTimeout ?? ApplicationOptions.DefaultCommandTimeout;
            using DbDataReader reader = await command.ExecuteReaderAsync();
            int recordCount = 0;
            destination.BeginLoadData();
            while (reader.Read())
            {
                DataRow row = destination.NewRow();
                for (int column = 0; column < mappings.Count; ++column)
                {
                    ExportColumnMapping mapping = mappings[column];
                    object value = DBNull.Value;
                    if (mapping.SourceIndex >= 0)
                    {
                        value = reader.GetValue(mapping.SourceIndex);
                    }
                    object? result = mapping.Action(mapping, value);
                    if (result == null)
                    {
                        row[mapping.DestinationIndex] = DBNull.Value;
                    }
                    else
                    {
                        row[mapping.DestinationIndex] = result;
                    }
                }
                destination.Rows.Add(row);
                recordCount++;
                totalCount++;
            }
            destination.EndLoadData();
            await BulkCopyAsync(export, mappings, destination);
            Console.WriteLine($"Exported records: {totalCount}");
            destination.Rows.Clear();
            if (recordCount < export.BatchSize)
            {
                break;
            }
            offset += export.BatchSize;
        }
    }

    private string CreateBaseQuery(TableExportOptions export, string sourceColumnList)
    {
        string baseQuery;
        if (export.SourceTable is not null)
        {
            var primaryKey = SourceIss.GetPrimaryKey(export.SourceTable!, "dbo");
            var primaryKeyColumnList = string.Join(",", primaryKey.Select(t => t.Name));
            baseQuery = $@"select {sourceColumnList} from [{export.SourceTable}] order by {primaryKeyColumnList}";
        }
        else if (export.SourceQuery is not null)
        {
            string primaryKeyColumnList = string.Join(", ", export.SourceQueryKey!);
            baseQuery = $@"select {sourceColumnList} from ({export.SourceQuery}) as t order by {primaryKeyColumnList}";
        }
        else
        {
            throw new InvalidOperationException();
        }

        return baseQuery;
    }

    private List<ExportColumnMapping> CreateColumnMappings(TableExportOptions export)
    {
        List<ExportColumnMapping> mappings = new();
        int sourceIndex = 0;
        int destinationIndex = 0;
        foreach (var column in export.Columns!)
        {
            if (column.Destination is not null && column.Action != ColumnAction.Skip)
            {
                ExportColumnMapping columnMappting = new()
                {
                    Source = column.Source!,
                    SourceIndex = column.Source is not null ? sourceIndex++ : -1,
                    Destination = column.Destination,
                    DestinationIndex = destinationIndex++,
                    Action = column.Action switch
                    {
                        ColumnAction.SetNull => SetNull,
                        ColumnAction.SetValue => throw new NotImplementedException(),
                        ColumnAction.Copy => Copy,
                        ColumnAction.Convert => Convert,
                        ColumnAction.MaskWithChar => MaskWithChar,
                        _ => throw new InvalidOperationException($"unsupported action {column.Action}")
                    }
                };
                if (column.Action == ColumnAction.Convert)
                {
                    columnMappting.Converter = (IConverter)ServiceProvider.GetRequiredService(Type.GetType(column.Parameter!, true)!);
                }
                else if (column.Action == ColumnAction.TypeConvert)
                {
                    switch(column.Parameter)
                    {
                        case "FromBoolToSmallInt":
                            columnMappting.Action = DefaultTypeConverter.FromBoolToSmallInt;
                            break;
                        case "FromByteArrayToDateTime":
                            columnMappting.Action = DefaultTypeConverter.FromByteArrayToDateTime;
                            break;
                        case "FromTinyIntToInt":
                            columnMappting.Action = DefaultTypeConverter.FromTinyIntToInt;
                            break;
                        case "FromTextToBigInt":
                            columnMappting.Action = DefaultTypeConverter.FromTextToBigInt;
                            break;
                        case "FromByteArrayToVarChar":
                            throw new InvalidOperationException("unsupported convertion");
                        case "FromBigIntToDoublePrecision":
                            columnMappting.Action = DefaultTypeConverter.FromBigIntToDoublePrecision;
                            break;



                        default:
                            throw new InvalidOperationException("unsupprted type converter");
                    }

                }
                mappings.Add(columnMappting);
            }
        }
        return mappings;
    }

    private Task BulkCopyAsync(TableExportOptions export, List<ExportColumnMapping> mappings, DataTable destination)
    {
        using DbConnection connection = Destination.CreateConnection();
        if (connection is NpgsqlConnection pgConnection)
        {
            string columnList = string.Join(", ", mappings.Select(t => t.Destination));
            pgConnection.Open();
            using NpgsqlBinaryImporter writer = pgConnection.BeginBinaryImport($"copy dbo.\"{export.DestinationTable}\" ({columnList}) from stdin (format binary)");
            foreach (DataRow row in destination.Rows)
            {
                writer.StartRow();
                foreach (var mapping in mappings)
                {
                    object value = row[mapping.DestinationIndex];
                    if (value is DBNull)
                    {
                        writer.Write((object?)null);
                    }
                    else
                    {
                        writer.Write(value);
                    }
                }
            }
            writer.Complete();
            writer.Close();
        }
        return Task.CompletedTask;
    }

    private DataTable CreateDataTable(TableExportOptions export, List<ExportColumnMapping> mappings)
    {
        List<ColumnInfo> tableColumns = DestinationIss.GetColumns(export.DestinationTable!, "dbo");

        DataTable table = new(export.DestinationTable);
        foreach (var column in mappings)
        {
            var tableColumn = tableColumns.Single(t => t.Name == column.Destination);
            DataColumn dataColumn = new(column.Destination, DataTypeConverter.GetClrType(tableColumn.DataType));
            dataColumn.AllowDBNull = tableColumn.IsNullable;
            table.Columns.Add(dataColumn);
        }
        return table;
    }

    private static object? Convert(ExportColumnMapping mapping, object value)
    {
        if (value is DBNull)
        {
            return null;
        }
        return mapping.Converter.Convert(value);
    }

    private static object? Copy(ExportColumnMapping mapping, object value)
    {
        if (value is DBNull)
        {
            return null;
        }
        return value;
    }

    private static object? SetNull(ExportColumnMapping mapping, object value)
    {
        return null;
    }

    private static object? MaskWithChar(ExportColumnMapping mapping, object value)
    {
        if (value is DBNull)
        {
            return null;
        }
        string text = (string)value;
        return new string('*', text.Length);
    }

    private static class DefaultTypeConverter
    {
        public static object? FromTextToBigInt(ExportColumnMapping mapping, object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            throw new InvalidCastException("unsupported convertion");
        }

        public static object? FromBigIntToDoublePrecision(ExportColumnMapping mapping, object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            return (double)(long)value;
        }

        public static object? FromTinyIntToInt(ExportColumnMapping mapping, object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            return (int)(byte)value;
        }

        public static object? FromBoolToSmallInt(ExportColumnMapping mapping, object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            return (bool)value ? (short)1 : (short)0;
        }

        public static object? FromByteArrayToDateTime(ExportColumnMapping mapping, object value)
        {
            if (value is DBNull)
            {
                return null;
            }
            return DateTime.UtcNow;
        }
    }


    private class ExportColumnMapping
    {
        public string Source { get; set; } = null!;

        public int SourceIndex { get; set; }

        public string Destination { get; set; } = null!;

        public int DestinationIndex { get; set; }

        public Func<ExportColumnMapping, object, object?> Action { get; set; } = null!;

        public IConverter Converter { get; set; } = null!;
    }
}
