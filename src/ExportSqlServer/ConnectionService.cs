using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace ExportSqlServer;
public class ConnectionService
{
    public ConnectionService(IOptions<ApplicationOptions> options)
    {
        ApplicationOptions = options.Value;
    }

    private ApplicationOptions ApplicationOptions { get; }

    public SqlConnection CreateConnection()
    {
        return new SqlConnection(ApplicationOptions.ConnectionString);
    }

    public int CommandTimeout => ApplicationOptions.CommandTimeout;
}
