namespace SqlServerToPostgres;
public class AnonymizerServiceOptions
{
    public string SubstitutionsFileName { get; set; } = null!;

    public string NamesXPath { get; set; } = null!;

    public string? CleanupXPath { get; set; }
}
