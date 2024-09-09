using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Pg = Migration.PostgresDb.Data.Models;
using Sql = Migration.SqlServer.Data.Models;

namespace SqlServerToPostgres;

internal class Program
{
    public static readonly object DestinationKey = new object();
    public static readonly object SourceKey = new object();

    public static IConfigurationRoot Configuration { get; set; } = null!;

    public static IServiceProvider ServiceProvider { get; set; } = null!;

    public static ApplicationOptions ApplicationOptions { get; set; } = null!;

    private static async Task Main(string[] args)
    {
        try
        {
            Configure(args);

            IOperationsService service;
            if (ApplicationOptions.OperationsType == OperationsType.GenerateExportOptions)
            {
                service = ServiceProvider.GetRequiredService<GenerateExportOptionsService>();
            }
            else if (ApplicationOptions.OperationsType == OperationsType.Export)
            {
                service = ServiceProvider.GetRequiredService<ExportService>();
            }
            else
            {
                throw new InvalidOperationException("unsupported operations type");
            }

            await service.RunAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }


    private static void Configure(string[] args)
    {
        Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, false)
            .AddCommandLine(args)
            .Build();

        ServiceCollection services = new();
        services.Configure<ApplicationOptions>(Configuration);

        services.AddDbContextPool<Sql.MigrationSqlDbContext>(
            (sp, options) =>
            {
                var o = sp.GetRequiredService<IOptions<ApplicationOptions>>();
                options.UseSqlServer(o.Value.SourceConnectionString);
            }
        );

        services.AddDbContextPool<Pg.MigrationPostresDbContext>(
            (sp, options) =>
            {
                var o = sp.GetRequiredService<IOptions<ApplicationOptions>>();
                options.UseNpgsql(o.Value.DestinationConnectionString);
            }
        );

        services.AddSingleton<XmlAnonymizerService>();
        services.AddSingleton<TextAnonymizerService>();

        ProviderManager.Register();

        services.AddKeyedTransient<ConnectionService>(SourceKey, (sp, key) =>
        {
            if (key is null)
            {
                throw new InvalidOperationException("key is required");
            }
            return ActivatorUtilities.CreateInstance<ConnectionService>(sp, key);
        });
        services.AddKeyedTransient<ConnectionService>(DestinationKey, (sp, key) =>
        {
            if (key is null)
            {
                throw new InvalidOperationException("key is required");
            }
            return ActivatorUtilities.CreateInstance<ConnectionService>(sp, key);
        });

        services.AddKeyedSingleton<ConnectionService>(SourceKey, (sp, key) =>
        {
            if (key is null)
            {
                throw new InvalidOperationException("key is required");
            }
            return ActivatorUtilities.CreateInstance<ConnectionService>(sp, key);
        });
        services.AddKeyedSingleton<ConnectionService>(DestinationKey, (sp, key) =>
        {
            if (key is null)
            {
                throw new InvalidOperationException("key is required");
            }
            return ActivatorUtilities.CreateInstance<ConnectionService>(sp, key);
        });

        services.AddKeyedSingleton<InformationSchemaService>(SourceKey, (sp, key) =>
        {
            if (key is null)
            {
                throw new InvalidOperationException("key is required");
            }
            return ActivatorUtilities.CreateInstance<InformationSchemaService>(sp, key);
        });
        services.AddKeyedSingleton<InformationSchemaService>(DestinationKey, (sp, key) =>
        {
            if (key is null)
            {
                throw new InvalidOperationException("key is required");
            }
            return ActivatorUtilities.CreateInstance<InformationSchemaService>(sp, key);
        });

        services.AddTransient<GenerateExportOptionsService>();
        services.AddTransient<ExportService>();

        ServiceProvider = services.BuildServiceProvider();

        ApplicationOptions = ServiceProvider.GetRequiredService<IOptions<ApplicationOptions>>().Value;
    }
}
