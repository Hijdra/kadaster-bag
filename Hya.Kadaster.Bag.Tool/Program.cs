using System.CommandLine.Builder;
using System.CommandLine.Hosting;
using System.CommandLine.Parsing;
using Hya.Kadaster.Bag;
using Hya.Kadaster.Bag.Tool;
using Hya.Kadaster.Bag.Tool.Commands;
using Hya.Kadaster.Bag.Tool.Writers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

await BuildCommandLine()
    .UseHost(_ => Host.CreateDefaultBuilder(),
        host =>
        {
            host.ConfigureLogging(logging => { logging.ClearProviders(); })
                .ConfigureServices((context, services) =>
                {
                    var config = context.Configuration;
                    services.AddBagServices(options =>
                    {
                        options.ApiKey = Environment.GetEnvironmentVariable(EnvConfig.ApiKey, EnvironmentVariableTarget.User) ?? "";
                        bool.TryParse(Environment.GetEnvironmentVariable(EnvConfig.IsLive, EnvironmentVariableTarget.User), out var isLive);
                        options.IsLive = isLive;
                    });

                    services.AddTransient<IOutputWriter, JsonWriter>();
                    services.AddTransient<IOutputWriter, TableWriter>();
                })
                .UseCommandHandler<Auth, Auth.Handler>()
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