using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace SqlServerToPostgres;

public enum DataType
{
    Bool,
    SmallInt,
    Int,
    BigInt,
    Real,
    Float,
    Decimal,
    Date,
    DateTime,
    Time,
    VarChar,
    Uuid,
    Text,
    DoublePrecision,
    ByteArray,
    Xml
}


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
                Console.Write($"{++totalCount,8}: ");
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
                    Console.Write($"{result?.ToString()?.Truncate(64)}, ");
                }
                destination.Rows.Add(row);
                Console.WriteLine();
                recordCount++;
            }
            destination.EndLoadData();
            await BulkCopyAsync(export, mappings, destination);
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

        DataTable table = new DataTable(export.DestinationTable);
        foreach (var column in mappings)
        {
            var tableColumn = tableColumns.Single(t => t.Name == column.Destination);
            Type dataType = GetClrType(GetPostgresColumnDataType(tableColumn.DataType, tableColumn.CharacterMaximumLength));
            DataColumn dataColumn = new DataColumn(column.Destination, dataType);
            table.Columns.Add(dataColumn);
        }
        return table;
    }

    public Type GetClrType(DataType dataType)
    {
        switch (dataType)
        {
            case DataType.BigInt:
                return typeof(long);
            case DataType.Bool:
                return typeof(bool);
            case DataType.Date:
                return typeof(DateTime);
            case DataType.DateTime:
                return typeof(DateTime);
            case DataType.Time:
                return typeof(DateTime);
            case DataType.Decimal:
                return typeof(decimal);
            case DataType.Float:
                return typeof(double);
            case DataType.Int:
                return typeof(int);
            case DataType.Real:
                return typeof(float);
            case DataType.SmallInt:
                return typeof(short);
            case DataType.Text:
                return typeof(string);
            case DataType.Uuid:
                return typeof(Guid);
            case DataType.VarChar:
                return typeof(string);
            case DataType.DoublePrecision:
                return typeof(double);
            case DataType.ByteArray:
                return typeof(byte[]);
            case DataType.Xml:
                return typeof(string);
            default:
                throw new InvalidOperationException();
        }
    }

    private DataType GetSqlColumnDataType(string dataType, int? maxLength)
    {
        switch (dataType.ToLower())
        {
            case "bigint":
                return DataType.BigInt;
            case "bit":
                return DataType.Bool;
            case "char":
                return DataType.VarChar;
            case "date":
                return DataType.Date;
            case "datetime":
            case "datetime2":
                return DataType.DateTime;
            case "decimal":
                return DataType.Decimal;
            case "int":
                return DataType.Int;
            case "smallint":
                return DataType.SmallInt;
            case "uniqueidentifier":
                return DataType.Uuid;
            case "nvarchar":
            case "varchar":
                if (maxLength == -1)
                {
                    return DataType.Text;
                }
                return DataType.VarChar;
            case "time":
                return DataType.Time;
            case "float":
                return DataType.DoublePrecision;
            case "varbinary":
                return DataType.ByteArray;
            case "timestamp":
                return DataType.ByteArray;
            case "tinyint":
                return DataType.SmallInt;
            case "xml":
                return DataType.Xml;
            case "text":
            case "ntext":
                return DataType.Text;
            default:
                throw new InvalidOperationException($"unsupported data type: {dataType}");
        }

    }

    private DataType GetPostgresColumnDataType(string dataType, int? maxLength)
    {
        switch (dataType.ToLower())
        {
            case "bigint":
                return DataType.BigInt;
            case "boolean":
                return DataType.Bool;
            case "character varying":
                return DataType.VarChar;
            case "date":
                return DataType.Date;
            case "integer":
                return DataType.Int;
            case "numeric":
                return DataType.Decimal;
            case "smallint":
                return DataType.SmallInt;
            case "text":
                return DataType.Text;
            case "timestamp without time zone":
                return DataType.DateTime;
            case "time without time zone":
                return DataType.Time;
            case "uuid":
                return DataType.Uuid;
            case "double precision":
                return DataType.DoublePrecision;
            case "bytea":
                return DataType.ByteArray;
            case "xml":
                return DataType.Xml;
            default:
                throw new InvalidOperationException($"unsupported data type: {dataType}");
        }
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

    public class ExportColumnMapping
    {
        public string Source { get; set; } = null!;


        public int SourceIndex { get; set; }

        public string Destination { get; set; } = null!;

        public int DestinationIndex { get; set; }

        public Func<ExportColumnMapping, object, object?> Action { get; set; } = null!;

        public IConverter Converter { get; set; } = null!;
    }
}
