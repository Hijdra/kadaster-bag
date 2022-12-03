# Kadaster Bag (.NET library)
This .NET library implements the open Kadaster Bag API from https://github.com/lvbag/BAG-API/

Note: currently only postal lookup supported

## How to use

This library uses default Logging, Dependency Injection and Configuration from Microsoft.

To get started all services can be registered through `.AddBagServices()` like the following example:
```csharp
using var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        var config = context.Configuration;
        services.AddBagServices(options =>
        {
            options.ApiKey = "TOKEN";
            options.IsLive = false;
        });
    })
    .Build();
    
var addressService = host.Services.GetRequiredService<IAddressService>();
```

This library will not throw any Exception but gives you a result object which can contain both the Exception or the actual result.

```csharp
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
```

Or you can let it throw the Exception or return the result by:
```csharp
try
{
    var result = await addressService.FindAsync("1011PN", 1);
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
```

## Classes and interfaces

| Service        | Interface       | Swagger documentation                                             |
|----------------|-----------------|-------------------------------------------------------------------|
| AddressService | IAddressService | https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres |
