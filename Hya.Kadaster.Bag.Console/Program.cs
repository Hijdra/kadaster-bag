using Hya.Kadaster.Bag;
using Hya.Kadaster.Bag.Console.HostedServices;
using Hya.Kadaster.Bag.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using var host = Host.CreateDefaultBuilder()
    .ConfigureAppConfiguration(cfg =>
    {
        cfg.AddJsonFile("appsettings.json");
        cfg.AddEnvironmentVariables("Hya_");
    })
    .ConfigureLogging(logging =>
    {
        logging.ClearProviders();
    })
    .ConfigureServices((context, services) =>
    {
        var config = context.Configuration;
        services.AddBagServices(options => config.GetSection(BagOptions.DefaultSection).Bind(options));
        services.AddHostedService<ConsoleService>(); 
    })
    .UseConsoleLifetime()
    .Build();

host.Run();