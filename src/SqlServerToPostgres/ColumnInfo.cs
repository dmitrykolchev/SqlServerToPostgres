namespace SqlServerToPostgres;

public class ColumnInfo
{
    public string Name { get; set; } = null!;

    public bool IsNullable { get; set; }

    public string DataType { get; set; } = null!;

    public int? CharacterMaximumLength { get; set; }

    public byte? NumericPrecision { get; set; }

    public int? NumericScale { get; set; }

    public int OrdinalPosition { get; set; }

    public string TableSchema { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public override string ToString()
    {
        if (DataType == null)
        {
            return Name;
        }
        return $"{Name} {DataType} {(IsNullable ? "null" : "not null")}";
    }
}
