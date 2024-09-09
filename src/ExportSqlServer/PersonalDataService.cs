using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Finder;

public class PersonalDataService
{
    public PersonalDataService(
        IOptions<ApplicationOptions> options,
        ConnectionService connectionService,
        InformationSchema informationSchema)
    {
        ApplicationOptions = options.Value;
        ConnectionService = connectionService;
        InformationSchema = informationSchema;
    }

    private ApplicationOptions ApplicationOptions { get; }

    private ConnectionService ConnectionService { get; }

    private InformationSchema InformationSchema { get; }

    public HashSet<string> LoadFullNames()
    {
        Console.WriteLine("Loading full names");

        Dictionary<string, List<string>> primaryKeys = InformationSchema.GetPrimaryKeys();
        HashSet<string> names = new();
        int tableIndex = 0;
        foreach (var fullName in ApplicationOptions.FullNames)
        {
            List<string> primaryKeyColumns = primaryKeys[fullName.TableName];
            string primaryKey = string.Join(", ", primaryKeyColumns.Select(t => $"[{t}]"));

            Console.WriteLine($"Loading fullnames from {fullName.TableName}.{fullName.FieldName}[{primaryKey}]");

            using SqlConnection connection = ConnectionService.CreateConnection();
            connection.Open();
            ++tableIndex;
            Console.WriteLine($"{tableIndex,4}: Reading names from table [{fullName.TableName}]");
            Console.Write("\t");
            int total = 0;
            for (int offset = 0; ; offset += ApplicationOptions.BatchSize)
            {
                string sqlText = $@"select [{fullName.FieldName}] from [{fullName.TableName}]
order by {primaryKey} OFFSET {offset} ROWS FETCH NEXT {ApplicationOptions.BatchSize} ROWS ONLY";

                using SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlText;
                command.CommandTimeout = ApplicationOptions.CommandTimeout;

                int count = 0;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            names.Add(reader.GetString(0).Trim().Replace("  ", " "));
                        }
                        count++;
                        total++;
                    }
                    Console.Write(".");
                }
                if (count < ApplicationOptions.BatchSize || total >= ApplicationOptions.MaxRecordLoad)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"\tRecord count: {total}");
        }
        return names;
    }
}
