using System.Text.Json;
using IO.Kadaster.Bag;
using IO.Kadaster.Bag.Exceptions;
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

try
{
    var result = await addressService.FindAsync("1011PN", "1");
    var addresses = result.GetOrThrow();
    if (addresses.Embedded != null)
    {
        Console.WriteLine(JsonSerializer.Serialize(addresses.Embedded.Adressen[0])); 
    }
    else
    {
        Console.WriteLine("No address found");
    }
}
catch (BagException e)
{
    Console.WriteLine($"Error: {JsonSerializer.Serialize(e.Error)}");
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

lifetime.StopApplication();
await host.WaitForShutdownAsync();