using System.Text.Json;
using IO.Kadaster.Bag;
using IO.Kadaster.Bag.Options;
using IO.Kadaster.Bag.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder()
    .ConfigureAppConfiguration(cfg => { cfg.AddJsonFile("appsettings.json"); })
    .ConfigureServices((context, services) =>
    {
        var config = context.Configuration;
        services.AddBagServices(options => config.GetSection(BagOptions.DefaultSection).Bind(options));
    })
    .UseConsoleLifetime()
    .Build();

await host.StartAsync();
var lifetime = host.Services.GetRequiredService<IHostApplicationLifetime>();

var addressService = host.Services.GetRequiredService<IAddressService>();

var result = await addressService.FindAsync("1011PN", "1");

Console.WriteLine($"Success: {result.Ok}");
Console.WriteLine($"Object: {JsonSerializer.Serialize(result.Object)}");
Console.WriteLine($"Error: {JsonSerializer.Serialize(result.Error)}");

lifetime.StopApplication();
await host.WaitForShutdownAsync();