namespace ExportSqlServer;

public enum Gender
{
    Unknown,
    Female,
    Male
}

public class FullNameEntry
{
    public string? FullName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? Surname { get; set; }

    public Gender Gender { get; set; }
}
