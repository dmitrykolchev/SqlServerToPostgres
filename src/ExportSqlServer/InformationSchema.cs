// <copyright file="InformationSchema.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Microsoft.Data.SqlClient;

namespace Finder;
public class InformationSchema
{
    private static readonly string GetPrimaryKeysSql = @"
SELECT 
	TC.TABLE_SCHEMA, 
	TC.TABLE_NAME, 
	TC.CONSTRAINT_SCHEMA, 
	TC.CONSTRAINT_NAME,
	CU.COLUMN_NAME,
	KCU.ORDINAL_POSITION
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
	TC.CONSTRAINT_SCHEMA, 
	TC.CONSTRAINT_NAME,
	KCU.ORDINAL_POSITION
";

    public InformationSchema(ConnectionService connectionService)
    {
        ConnectionService = connectionService;
    }

    private ConnectionService ConnectionService { get; }

    public Dictionary<string, List<string>> GetPrimaryKeys()
    {
        Console.WriteLine("Loading primary keys");
        using SqlConnection connection = ConnectionService.CreateConnection();
        connection.Open();
        using SqlCommand command = connection.CreateCommand();
        command.CommandText = GetPrimaryKeysSql;
        command.CommandTimeout = ConnectionService.CommandTimeout;

        using SqlDataReader reader = command.ExecuteReader();
        Dictionary<string, List<string>> keys = new(StringComparer.InvariantCultureIgnoreCase);
        int tableSchemaOrdinal = reader.GetOrdinal("TABLE_SCHEMA");
        int tableNameOrdinal = reader.GetOrdinal("TABLE_NAME");
        int columnNameOrdinal = reader.GetOrdinal("COLUMN_NAME");
        while (reader.Read())
        {
            string tableSchema = reader.GetString(tableSchemaOrdinal);
            string tableName = reader.GetString(tableNameOrdinal);
            string columnName = reader.GetString(columnNameOrdinal);
            string key = tableName;
            if (!keys.TryGetValue(key, out List<string>? value))
            {
                value = new();
                keys.Add(key, value);
            }
            value.Add(columnName);
        }
        Console.WriteLine("Primary keys loaded successfully");
        return keys;
    }
}
