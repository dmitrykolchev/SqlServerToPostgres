using Microsoft.Extensions.Options;
using System.Data.Common;

namespace SqlServerToPostgres;


public class ConnectionService
{
    public ConnectionService(IOptions<ApplicationOptions> options, object key)
    {
        ApplicationOptions = options.Value;
        if (key == Program.SourceKey)
        {
            ConnectionString = ApplicationOptions.SourceConnectionString ??
                throw new InvalidOperationException("configuration SourceConnectionString");
            Provider = ProviderManager.GetProvider(ApplicationOptions.SourceProviderType);
            ProviderType = ApplicationOptions.SourceProviderType;
        }
        else if (key == Program.DestinationKey)
        {
            ConnectionString = ApplicationOptions.DestinationConnectionString ??
                throw new InvalidOperationException("configuration DestinationConnectionString");
            Provider = ProviderManager.GetProvider(ApplicationOptions.DestinationProviderType);
            ProviderType = ApplicationOptions.DestinationProviderType;
        }
        else
        {
            throw new ArgumentException("invalid key", nameof(key));
        }
    }

    private ApplicationOptions ApplicationOptions { get; }

    public string ConnectionString { get; }

    public DbProviderFactory Provider { get; }

    public ProviderType ProviderType { get; }

    public string DefaultSchema => ProviderType switch
    {
        ProviderType.SqlServer => "dbo",
        ProviderType.Npgsql => "public",
        ProviderType.Postgres => "public",
        _ => throw new InvalidOperationException("invalid provider type")
    };

    public DbConnection CreateConnection()
    {
        DbConnection connection = Provider.CreateConnection()!;
        connection.ConnectionString = ConnectionString;
        return connection;
    }

    public int DefaultCommandTimeout => ApplicationOptions.DefaultCommandTimeout;
}
