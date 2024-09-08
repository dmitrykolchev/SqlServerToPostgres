using System.Text.Json.Serialization;

namespace SqlServerToPostgres;

public enum OperationsType
{
    Export,
    GenerateExportOptions
}

public class ApplicationOptions
{
    public OperationsType OperationsType { get; set; }
    public ProviderType DestinationProviderType { get; set; } = ProviderType.Postgres;
    public string? DestinationConnectionString { get; set; }

    public ProviderType SourceProviderType { get; set; } = ProviderType.SqlServer;
    public string? SourceConnectionString { get; set; }

    public int DefaultCommandTimeout { get; set; } = 30;

    public AnonymizerServiceOptions? Anonymizer { get; set; }

    public TableExportOptions[]? Exports { get; set; }
}

public class TableExportOptions
{
    /// <summary>
    /// Destination table name
    /// </summary>
    public string? DestinationTable { get; set; }

    /// <summary>
    /// Source table name
    /// </summary>
    public string? SourceTable { get; set; }
    /// <summary>
    /// Source querty (SQL syntax)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SourceQuery { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? SourceQueryKey { get; set; }

    /// <summary>
    /// Export batch size
    /// </summary>
    public int BatchSize { get; set; } = 1000;

    /// <summary>
    /// Command timeout. If it is null then used DefaultCommandTimeout from ApplicationOptions
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? CommandTimeout { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Filter { get; set; }

    /// <summary>
    /// Settings for exported columns
    /// </summary>
    public ColumnExportOptions[]? Columns { get; set; }
}

public enum ColumnAction
{
    Skip,
    Copy,
    Convert,
    SetNull,
    SetValue,
    MaskWithChar,
}

public class ColumnExportOptions
{
    /// <summary>
    /// Destination column name
    /// </summary>
    public string? Destination { get; set; }
    /// <summary>
    /// Source column name
    /// </summary>
    public string? Source { get; set; }
    /// <summary>
    /// Export action. Default action is Copy
    /// </summary>
    public ColumnAction Action { get; set; }
    /// <summary>
    /// Action parameter. Parameter is action specific
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Parameter { get; set; }
}
