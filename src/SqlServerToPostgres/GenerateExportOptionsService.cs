using Microsoft.Extensions.DependencyInjection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace SqlServerToPostgres;

public class GenerateExportOptionsService: IOperationsService
{
    private InformationSchemaService? _sourceIss;
    private InformationSchemaService? _destinationIss;

    public GenerateExportOptionsService(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }

    private IServiceProvider ServiceProvider { get; }

    private InformationSchemaService SourceIss => 
        _sourceIss ??= ServiceProvider.GetRequiredKeyedService<InformationSchemaService>(Program.SourceKey);

    private InformationSchemaService DestinationIss => 
        _destinationIss ??= ServiceProvider.GetRequiredKeyedService<InformationSchemaService>(Program.DestinationKey);

    public Task RunAsync()
    {
        List<TableExportOptions> tableExports = new();

        var sourceTables = SourceIss.GetTables("dbo");
        var destinationTables = DestinationIss.GetTables("dbo");

        foreach (var destinationTable in destinationTables)
        {
            Console.WriteLine(destinationTable);
            TableExportOptions tableExportOptions = new()
            {
                DestinationTable = destinationTable,
                SourceTable = sourceTables.FirstOrDefault(t => t == destinationTable),
                Columns = GenerateTableExportOptions(destinationTable).ToArray()
            };
            tableExports.Add(tableExportOptions);
        }
        ApplicationOptions options = new ApplicationOptions()
        {
            Exports = tableExports.ToArray()
        };

        SaveOptions(options);

        return Task.CompletedTask;
    }

    private List<ColumnExportOptions> GenerateTableExportOptions(string destinationTable)
    {
        List<ColumnInfo> sourceColumns = SourceIss!.GetColumns(destinationTable, "dbo");
        List<ColumnInfo> destinationColumns = DestinationIss!.GetColumns(destinationTable, "dbo");
        List<ColumnExportOptions> columns = new();
        for (int index = 0; index < destinationColumns.Count; ++index)
        {
            ColumnExportOptions column = new();
            columns.Add(column);
            ColumnInfo destination = destinationColumns[index];
            column.Destination = destination.Name;
            ColumnInfo? sourceColumn = sourceColumns.Where(t => t.Name == destination.Name).FirstOrDefault();
            if (sourceColumn is not null)
            {
                sourceColumns.Remove(sourceColumn);
                column.Source = sourceColumn.Name;
                if (sourceColumn.DataType == DataType.Xml)
                {
                    column.Action = ColumnAction.Convert;
                    column.Parameter = typeof(XmlAnonymizerService).AssemblyQualifiedName;
                }
                else if (sourceColumn.Name.EndsWith("fullname", StringComparison.CurrentCultureIgnoreCase) &&
                    (sourceColumn.DataType == DataType.VarChar || sourceColumn.DataType == DataType.Text))
                {
                    column.Action = ColumnAction.Convert;
                    column.Parameter = typeof(TextAnonymizerService).AssemblyQualifiedName;
                }
                else if ((sourceColumn.Name.EndsWith("login", StringComparison.CurrentCultureIgnoreCase) ||
                    sourceColumn.Name.EndsWith("email", StringComparison.CurrentCultureIgnoreCase)) &&
                    (sourceColumn.DataType == DataType.VarChar || sourceColumn.DataType == DataType.Text))
                {
                    column.Action = ColumnAction.MaskWithChar;
                    column.Parameter = "*";
                }
                else
                {
                    column.Action = ColumnAction.Copy;
                }
            }
            else
            {
                column.Action = ColumnAction.Skip;
            }

        }
        foreach (var source in sourceColumns)
        {
            ColumnExportOptions column = new();
            columns.Add(column);
            column.Source = source.Name;
            column.Action = ColumnAction.Skip;
        }
        return columns;
    }

    private static void SaveOptions(ApplicationOptions options)
    {
        using FileStream file = File.Create("exports.json");
        JsonSerializer.Serialize(file, options, new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        });
    }
}
