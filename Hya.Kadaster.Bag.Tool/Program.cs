using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.Parsing;
using Hya.Kadaster.Bag;
using Hya.Kadaster.Bag.Tool.Commands;
using Hya.Kadaster.Bag.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

await BuildCommandLine()
    .UseHost(_ => Host.CreateDefaultBuilder(),
        host =>
        {
            host.ConfigureAppConfiguration(cfg =>
                {
                    cfg.AddJsonFile("appsettings.json");
                    cfg.AddEnvironmentVariables("Hya_");
                })
                .ConfigureLogging(logging => { logging.ClearProviders(); })
                .ConfigureServices((context, services) =>
                {
                    var config = context.Configuration;
                    services.AddBagServices(options => config.GetSection(BagOptions.DefaultSection).Bind(options));
                })
                .UseCommandHandler<AddressFind, AddressFind.Handler>()
                .UseCommandHandler<AddressGet, AddressGet.Handler>();
        })
    .UseDefaults()
    .Build()
    .InvokeAsync(args);

static CommandLineBuilder BuildCommandLine()
{
    var root = new Bag();
    return new CommandLineBuilder(root);
}