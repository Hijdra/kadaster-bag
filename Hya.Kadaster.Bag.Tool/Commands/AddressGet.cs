using System.CommandLine;
using System.CommandLine.Invocation;
using Hya.Kadaster.Bag.Tool.Extensions;
using Hya.Kadaster.Bag.Tool.Models;
using Hya.Kadaster.Bag.Services;
using Hya.Kadaster.Bag.Tool.Writers;

namespace Hya.Kadaster.Bag.Tool.Commands;

public class AddressGet : Command
{
    public AddressGet() : base("get", "Get single address")
    {
        AddArgument(new Argument<string>("identifier"));
    }

    public new class Handler : OutputHandler, ICommandHandler
    {
        private readonly IAddressService _addressService;

        public Handler(IAddressService addressService, IEnumerable<IOutputWriter> writers) : base(writers)
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
                        HouseNumberAddition = address.Huisnummertoevoeging,
                        HouseLetter = address.Huisletter,
                        City = address.WoonplaatsNaam,
                        Street = address.OpenbareRuimteNaam
                    };

                    Write(context.Console, lookup);

                    return 0;
                });
        }
    }
}