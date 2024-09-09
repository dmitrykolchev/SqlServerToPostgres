// <copyright file="VerificationService.cs" company="Division By Zero">
// Copyright (c) 2024 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Finder;
public class VerificationService
{
    private readonly ApplicationOptions _options;

    public VerificationService(
        IOptions<ApplicationOptions> options,
        ConnectionService connectionService)
    {
        _options = options.Value;
        ConnectionService = connectionService;
    }

    private ApplicationOptions ApplicationOptions => _options;
    private ConnectionService ConnectionService { get; }

    public void VerifyConfiguration()
    {
        VerifyConnection();

        VerifyFullNames();
    }


    private void VerifyConnection()
    {
        try
        {
            Console.WriteLine("Testing connection to SQL Server...");
            Console.WriteLine($"Connection string: {ApplicationOptions.ConnectionString}");
            using SqlConnection connection = ConnectionService.CreateConnection();
            connection.Open();
            Console.WriteLine("Connection to SQL Server succeeded");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    private void VerifyFullNames()
    {
        Console.WriteLine("Verifying tables with people full names");
        using SqlConnection connection = ConnectionService.CreateConnection();
        connection.Open();
        int count = 0;
        foreach (var fullname in ApplicationOptions.FullNames)
        {
            try
            {
                count++;
                Console.Write($"{count,4}: Verifying field [{fullname.TableName}].[{fullname.FieldName}]. ");
                string sql = $"select top 1 [{fullname.FieldName}] from [{fullname.TableName}]";
                using SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.ExecuteScalar();
                Console.WriteLine($"-> OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine("-> FAIL");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        Console.WriteLine("Tables with people full names successfully verified");
    }
}
