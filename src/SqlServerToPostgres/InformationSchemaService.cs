using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Data.Common;

namespace SqlServerToPostgres;

public class InformationSchemaService
{
    private Dictionary<string, List<ColumnInfo>>? _allKeys;
    private Dictionary<string, List<ColumnInfo>>? _allColumns;

    public InformationSchemaService(
        IOptions<ApplicationOptions> options,
        IServiceProvider serviceProvider,
        object key)
    {
        ApplicationOptions = options.Value;
        ConnectionService = serviceProvider.GetRequiredKeyedService<ConnectionService>(key);
    }

    private ApplicationOptions ApplicationOptions { get; }

    private ConnectionService ConnectionService { get; }

    public ProviderType ProviderType => ConnectionService.ProviderType;

    public DataType GetColumnDataType(string dataType, int? maxLength)
    {
        switch (ProviderType)
        {
            case ProviderType.SqlServer:
                return DataTypeConverter.GetSqlColumnDataType(dataType, maxLength);
            case ProviderType.Npgsql:
            case ProviderType.Postgres:
                return DataTypeConverter.GetPostgresColumnDataType(dataType, maxLength);
            default:
                throw new InvalidOperationException($"Unsupported provider type {ProviderType}.");
        }
    }

    private static readonly string GetTablesSql = @"SELECT 
    TABLE_NAME 
FROM 
    INFORMATION_SCHEMA.TABLES 
WHERE 
    TABLE_SCHEMA = @tableSchema 
ORDER BY 
    TABLE_NAME";
    public List<string> GetTables(string? tableSchema = null)
    {
        using DbConnection connection = ConnectionService.CreateConnection();
        connection.Open();
        using DbCommand command = connection.CreateCommand();
        command.CommandText = GetTablesSql;
        command.CommandTimeout = ApplicationOptions.DefaultCommandTimeout;

        DbParameter tableSchemaParameter = command.CreateParameter();
        tableSchemaParameter.ParameterName = "@tableSchema";
        tableSchemaParameter.Value = tableSchema ?? ConnectionService.DefaultSchema;
        command.Parameters.Add(tableSchemaParameter);

        using DbDataReader reader = command.ExecuteReader();
        List<string> result = new();
        while (reader.Read())
        {
            result.Add(reader.GetString(0));
        }
        return result;
    }

    private static readonly string GetAllColumnsSQL = @"select 
    COLUMN_NAME,
    IS_NULLABLE,
    DATA_TYPE,
    CHARACTER_MAXIMUM_LENGTH,
    NUMERIC_PRECISION,
    NUMERIC_SCALE,
    TABLE_SCHEMA,
    TABLE_NAME,
    ORDINAL_POSITION
from 
    INFORMATION_SCHEMA.COLUMNS 
order by 
    TABLE_SCHEMA, TABLE_NAME, ORDINAL_POSITION";

    public Dictionary<string, List<ColumnInfo>> GetAllColumns()
    {
        if (_allColumns is null)
        {
            using DbConnection connection = ConnectionService.CreateConnection();
            connection.Open();
            using DbCommand command = connection.CreateCommand();
            command.CommandText = GetAllColumnsSQL;
            command.CommandTimeout = ApplicationOptions.DefaultCommandTimeout;

            using DbDataReader reader = command.ExecuteReader();
            List<ColumnInfo> result = new();
            while (reader.Read())
            {
                string nativeDataType = reader.GetString(2);
                int? characterMaximumLength = reader.IsDBNull(3) ? null : reader.GetInt32(3);
                ColumnInfo columnInfo = new()
                {
                    Name = reader.GetString(0),
                    IsNullable = reader.GetString(1) == "YES" ? true : false,
                    DataType = GetColumnDataType(nativeDataType, characterMaximumLength),
                    NativeDataType = nativeDataType,
                    CharacterMaximumLength = characterMaximumLength,
                    NumericPrecision = reader.IsDBNull(4) ? null : reader.GetByte(4),
                    NumericScale = reader.IsDBNull(5) ? null : reader.GetInt32(5),
                    TableSchema = reader.GetString(6),
                    TableName = reader.GetString(7),
                    OrdinalPosition = reader.GetInt32(8)
                };
                result.Add(columnInfo);
            }
            _allColumns = (from item in result
                           group item by item.TableName.ToUpper() + "_" + item.TableSchema.ToUpper() into g
                           select new
                           {
                               Key = g.Key,
                               Value = g.OrderBy(t => t.OrdinalPosition).ToList()
                           }).ToDictionary(t => t.Key, t => t.Value, StringComparer.CurrentCultureIgnoreCase);
        }
        return _allColumns;
    }

    public List<ColumnInfo> GetColumns(string tableName, string? tableSchema = null)
    {
        Dictionary<string, List<ColumnInfo>> allColumns = GetAllColumns();

        string key = tableName.ToUpper() + "_" + (tableSchema ?? ConnectionService.DefaultSchema).ToUpper();
        if (allColumns.TryGetValue(key, out List<ColumnInfo>? value))
        {
            return value;
        }
        return new List<ColumnInfo>();
    }

    private static readonly string GetAllPrimaryKeysSql = @"
SELECT 
	CU.COLUMN_NAME,
	KCU.ORDINAL_POSITION,
    TC.TABLE_SCHEMA,
    TC.TABLE_NAME
FROM 
	INFORMATION_SCHEMA.TABLE_CONSTRAINTS as TC INNER JOIN INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as CU 
		ON (TC.CONSTRAINT_SCHEMA = CU.CONSTRAINT_SCHEMA AND TC.CONSTRAINT_NAME = CU.CONSTRAINT_NAME)
		INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE as KCU
		ON (CU.CONSTRAINT_SCHEMA = KCU.CONSTRAINT_SCHEMA AND CU.CONSTRAINT_NAME = KCU.CONSTRAINT_NAME AND
			CU.COLUMN_NAME = KCU.COLUMN_NAME)
WHERE TC.CONSTRAINT_TYPE='PRIMARY KEY'
ORDER BY
    TC.TABLE_SCHEMA,
    TC.TABLE_NAME,
	KCU.ORDINAL_POSITION";

    public Dictionary<string, List<ColumnInfo>> GetAllPrimaryKey()
    {
        if (_allKeys is null)
        {
            using DbConnection connection = ConnectionService.CreateConnection();
            connection.Open();
            using DbCommand command = connection.CreateCommand();
            command.CommandText = GetAllPrimaryKeysSql;
            command.CommandTimeout = ApplicationOptions.DefaultCommandTimeout;

            using DbDataReader reader = command.ExecuteReader();
            List<ColumnInfo> result = new();
            while (reader.Read())
            {
                ColumnInfo columnInfo = new()
                {
                    Name = reader.GetString(0),
                    OrdinalPosition = reader.GetInt32(1),
                    TableSchema = reader.GetString(2),
                    TableName = reader.GetString(3)
                };
                result.Add(columnInfo);
            }
            _allKeys = (from item in result
                        group item by item.TableName.ToUpper() + "_" + item.TableSchema.ToUpper() into g
                        select new
                        {
                            Key = g.Key,
                            Value = g.OrderBy(t => t.OrdinalPosition).ToList()
                        }).ToDictionary(t => t.Key, t => t.Value, StringComparer.CurrentCultureIgnoreCase);
        }
        return _allKeys;
    }

    public List<ColumnInfo> GetPrimaryKey(string tableName, string? tableSchema = null)
    {
        var allKeys = GetAllPrimaryKey();

        string key = tableName.ToUpper() + "_" + (tableSchema ?? ConnectionService.DefaultSchema).ToUpper();
        if (allKeys.TryGetValue(key, out List<ColumnInfo>? value))
        {
            return value;
        }
        return new List<ColumnInfo>();
    }
}
