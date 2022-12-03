using System.Text.Json;
using Hya.Kadaster.Bag.Console.Models;
using Hya.Kadaster.Bag.Services;
using Microsoft.Extensions.Hosting;

namespace Hya.Kadaster.Bag.Console.HostedServices;

public class ConsoleService : IHostedService
{
    private readonly IHostApplicationLifetime _appLifetime;
    private readonly IAddressService _addressService;

    public ConsoleService(IHostApplicationLifetime appLifetime, IAddressService addressService)
    {
        _appLifetime = appLifetime;
        _addressService = addressService;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _appLifetime.ApplicationStarted.Register(() =>
        {
            Task.Run(async () =>
            {
                try
                {
                    await ExecuteAsync(cancellationToken);
                }
                finally
                {
                    _appLifetime.StopApplication();
                }
            }, cancellationToken);
        });

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    private async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        System.Console.WriteLine("Address lookup");

        var exit = false;

        while (!cancellationToken.IsCancellationRequested && !exit)
        {
            System.Console.Write("Command: ");
            var tool = System.Console.ReadLine();

            switch (tool)
            {
                case "address:find":
                    await ExecuteAddressLookupAsync();
                    break;
                case "address:get":
                    await ExecuteAddressAsync();
                    break;
                case "help":
                    System.Console.WriteLine("You can use: address:find, address:get");
                    break;
                case "exit":
                    exit = true;
                    break;
            }
        }
    }

    private async Task ExecuteAddressLookupAsync()
    {
        System.Console.Write("PostalCode: ");
        var postalCode = System.Console.ReadLine();
        System.Console.Write("HouseNumber: ");
        int.TryParse(System.Console.ReadLine(), out int houseNumber);

        var result = await _addressService.FindAsync(postalCode, houseNumber);
        var addressLookup = result.On(addresses =>
        {
            if (addresses.Embedded != null)
            {
                return new AddressLookup
                {
                    Id = addresses.Embedded.Adressen[0].NummeraanduidingIdentificatie,
                    PostalCode = addresses.Embedded.Adressen[0].Postcode,
                    HouseNumber = addresses.Embedded.Adressen[0].Huisnummer ?? 0,
                    City = addresses.Embedded.Adressen[0].WoonplaatsNaam,
                    Street = addresses.Embedded.Adressen[0].OpenbareRuimteNaam
                };
            }

            return default!;
        }, error => default!);

        if (addressLookup != null)
        {
            System.Console.WriteLine("Address: {0}", JsonSerializer.Serialize(addressLookup));
        }
        else
        {
            System.Console.WriteLine("Address not found");
        }
    }

    private async Task ExecuteAddressAsync()
    {
        System.Console.Write("Identifier: ");
        var identifier = System.Console.ReadLine();

        var result = await _addressService.GetAsync(identifier);
        var addressLookup = result.On(address =>
        {
            if (address != null)
            {
                return new AddressLookup
                {
                    Id = address.NummeraanduidingIdentificatie,
                    PostalCode = address.Postcode,
                    HouseNumber = address.Huisnummer ?? 0,
                    City = address.WoonplaatsNaam,
                    Street = address.OpenbareRuimteNaam
                };
            }

            return default!;
        }, error => default!);

        if (addressLookup != null)
        {
            System.Console.WriteLine("Address: {0}", JsonSerializer.Serialize(addressLookup));
        }
        else
        {
            System.Console.WriteLine("Address not found");
        }
    }
}