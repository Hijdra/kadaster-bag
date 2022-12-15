using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.IO;
using System.Text.Json;
using Hya.Kadaster.Bag.Console.Extensions;
using Hya.Kadaster.Bag.Console.Models;
using Hya.Kadaster.Bag.Services;

namespace Hya.Kadaster.Bag.Console.Commands;

public class AddressGet : Command
{
    public AddressGet() : base("address-get", "Get single address")
    {
        AddArgument(new Argument<string>("identifier"));
    }

    public new class Handler : ICommandHandler
    {
        private readonly IAddressService _addressService;

        public Handler(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public string Identifier { get; set; } // From DI

        public int Invoke(InvocationContext context) => InvokeAsync(context).GetAwaiter().GetResult();

        public async Task<int> InvokeAsync(InvocationContext context)
        {
            var get = await _addressService.GetAsync(Identifier);
            return get.HandleErrorState(
                context.Console,
                address =>
                {
                    var lookup = new AddressLookup
                    {
                        Id = address.NummeraanduidingIdentificatie,
                        PostalCode = address.Postcode,
                        HouseNumber = address.Huisnummer ?? 0,
                        City = address.WoonplaatsNaam,
                        Street = address.OpenbareRuimteNaam
                    };

                    context.Console.Out.WriteLine(JsonSerializer.Serialize(lookup));

                    return 0;
                });
        }
    }
}