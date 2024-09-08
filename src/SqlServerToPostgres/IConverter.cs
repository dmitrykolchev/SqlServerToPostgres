namespace SqlServerToPostgres;

public interface IConverter
{
    object? Convert(object? value);
}
