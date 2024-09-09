using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Finder;

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
