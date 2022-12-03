using System.Text.Json;
using Hya.Kadaster.Bag;
using Hya.Kadaster.Bag.Options;
using Hya.Kadaster.Bag.Services;
using Kadaster.Bag.Console;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder()
    .ConfigureAppConfiguration(cfg =>
    {
        cfg.AddJsonFile("appsettings.json");
        cfg.AddEnvironmentVariables("Hya_");
    })
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

var result = await addressService.FindAsync("1011PN", 1);
var addressLookup = result.On(addresses =>
{
    if (addresses.Embedded != null)
    {
        return new AddressLookup
        {
            PostalCode = addresses.Embedded.Adressen[0].Postcode,
            HouseNumber = addresses.Embedded.Adressen[0].Huisnummer ?? 0,
            City = addresses.Embedded.Adressen[0].WoonplaatsNaam,
            Street = addresses.Embedded.Adressen[0].OpenbareRuimteNaam,
        };
    }

    return default!;
}, error => default!);
    
Console.WriteLine(JsonSerializer.Serialize(addressLookup));

lifetime.StopApplication();
await host.WaitForShutdownAsync();