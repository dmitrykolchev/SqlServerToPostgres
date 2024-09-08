namespace ExportSqlServer;

public class TableFieldPair
{
    public string TableName { get; set; } = null!;
    public string FieldName { get; set; } = null!;
}

public class ApplicationOptions
{
    public string ConnectionString { get; set; } = null!;
    public FullNameOrder FullNameOrder { get; set; }
    public TableFieldPair[] FullNames { get; set; } = null!;
    public TableFieldPair[]? Logins { get; set; }
    public TableFieldPair[]? Passwords { get; set; }
    public string[] Tables { get; set; } = null!;
    public int BatchSize { get; set; } = 1000;
    public string NamesFileName { get; set; } = "fullnames.json";
    public string SubstitutionsFileName { get; set; } = "substitutions.json";
    public int CommandTimeout { get; set; } = 30;
    public int MaxRecordLoad { get; set; } = int.MaxValue;

}
