using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ExportSqlServer;

internal class Program
{
    public static IConfigurationRoot Configuration { get; set; } = null!;

    public static IServiceProvider ServiceProvider { get; set; } = null!;

    public static ApplicationOptions ApplicationOptions { get; set; } = null!;

    private static void Main(string[] args)
    {
        Configure(args);
        VerificationService verificationService = ServiceProvider.GetRequiredService<VerificationService>();
        verificationService.VerifyConfiguration();
        NameService nameService = ServiceProvider.GetRequiredService<NameService>();
        nameService.ParseAndSave();

        //List<string> fields = ["A", "B", "C"];
        //List<object> values = [DateTime.Now, null, 100];
        //List<object> values1 = [DateTime.Now, "Data", 101];

        //using MemoryStream memory = new();
        //MessagePackSerializer.Serialize(memory, fields);
        //MessagePackSerializer.Serialize(memory, values);
        //MessagePackSerializer.Serialize(memory, values1);
        //memory.Position = 0;
        //List<string>? f = (List<string>?)MessagePackSerializer.Deserialize(typeof(List<string>), memory);
        //List<object>? v = (List<object>?)MessagePackSerializer.Deserialize(typeof(List<object>), memory);
        //List<object>? v1 = (List<object>?)MessagePackSerializer.Deserialize(typeof(List<object>), memory);
    }

    private static void Configure(string[] args)
    {
        Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false, false)
            .AddCommandLine(args)
            .Build();

        ServiceCollection services = new();
        services.Configure<ApplicationOptions>(Configuration);
        services.AddTransient<ConnectionService>();
        services.AddTransient<VerificationService>();
        services.AddTransient<InformationSchema>();
        services.AddTransient<PersonalDataService>();
        services.AddTransient<NameService>();
        ServiceProvider = services.BuildServiceProvider();

        ApplicationOptions = ServiceProvider.GetRequiredService<IOptions<ApplicationOptions>>().Value;
    }
}
