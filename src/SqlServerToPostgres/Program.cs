using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Diagnostics;
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
        Configure(args);

        IOperationsService service;
        if (ApplicationOptions.OperationsType == OperationsType.GenerateExportOptions)
        {
            service = ServiceProvider.GetRequiredService<GenerateExportOptionsService>();
        }
        else if(ApplicationOptions.OperationsType == OperationsType.Export)
        {
            service = ServiceProvider.GetRequiredService<ExportService>();
        }
        else
        {
            throw new InvalidOperationException("unsupported operations type");
        }

        await service.RunAsync();

        return;

        using var scope = ServiceProvider.CreateScope();
        var sqlDb = scope.ServiceProvider.GetRequiredService<Sql.MigrationSqlDbContext>();
        //var pgDb = scope.ServiceProvider.GetRequiredService<Pg.MigrationPostresDbContext>();

        //using var transaction = pgDb.Database.BeginTransaction();
        try
        {
            await AnonymizeXml();
            //transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static async Task AnonymizeXml()
    {
        using var scope = ServiceProvider.CreateScope();
        Sql.MigrationSqlDbContext sqlDb = scope.ServiceProvider.GetRequiredService<Sql.MigrationSqlDbContext>();
        //var pgDb = scope.ServiceProvider.GetRequiredService<Pg.MigrationPostresDbContext>();
        XmlAnonymizerService anonymizerService = scope.ServiceProvider.GetRequiredService<XmlAnonymizerService>();
        Stopwatch sw = Stopwatch.StartNew();
        int records = 0;
        await foreach (var item in sqlDb.ActiveLearning.AsNoTracking().AsAsyncEnumerable())
        {
            string? result = (string?)anonymizerService.Convert(item.Data);
            records++;
        }
        sw.Stop();
        Console.WriteLine($"{(double)sw.ElapsedMilliseconds / records} ms per record");
    }

    private static async Task CopyDocTypes(Sql.MigrationSqlDbContext sqlDb, Pg.MigrationPostresDbContext pgDb)
    {
        await foreach (var item in sqlDb.SpxmlObjects.AsNoTracking().AsAsyncEnumerable())
        {
            pgDb.SpxmlObjects.Add(new Pg.SpxmlObjects
            {
                Id = item.Id,
                Form = item.Form,
                SpxmlForm = item.SpxmlForm,
                IsDeleted = item.IsDeleted,
                Modified = item.Modified,
            });
        }
        await foreach (var item in sqlDb.DocTypes.AsNoTracking().AsAsyncEnumerable())
        {
            pgDb.DocTypes.Add(new Pg.DocTypes
            {
                Id = item.Id,
                Code = item.Code,
                Name = item.Name,
                Category = item.Category,
                ObjectName = item.ObjectName,
                DispName = item.DispName,
                IsCraveForReboot = item.IsCraveForReboot,
                CustomWebTemplateId = item.CustomWebTemplateId,
                CustomAdminTemplateId = item.CustomAdminTemplateId,
                AccessBlockType = item.AccessBlockType,
                ModificationDate = item.ModificationDate,
                AppInstanceId = item.AppInstanceId,
            });
        }
        await foreach (var item in sqlDb.DocType.AsNoTracking().AsAsyncEnumerable())
        {
            pgDb.DocType.Add(new Pg.DocType
            {
                Id = item.Id,
                Created = item.Created,
                Modified = item.Modified,
                Data = item.Data,
            });
        }
        await pgDb.SaveChangesAsync();
    }


    private static async Task CopySpxmlBlobs(Sql.MigrationSqlDbContext sqlDb, Pg.MigrationPostresDbContext pgDb)
    {
        await foreach (var item in sqlDb.SpxmlBlobs.AsNoTracking().AsAsyncEnumerable())
        {
            pgDb.SpxmlBlobs.Add(new Pg.SpxmlBlobs
            {
                Url = item.Url,
                Created = item.Created,
                Modified = item.Modified,
                Data = item.Data,
                Ext = item.Ext,
                Ftime = item.Ftime
            });
            Console.WriteLine(item.Url);
        }
        await pgDb.SaveChangesAsync();
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
            if(key is null)
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
