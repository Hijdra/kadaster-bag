using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.IO;
using System.Text.Json;
using Hya.Kadaster.Bag.Console.Models;
using Hya.Kadaster.Bag.Exceptions;
using Hya.Kadaster.Bag.Models;
using Hya.Kadaster.Bag.Models.Generated;
using Hya.Kadaster.Bag.Services;

namespace Hya.Kadaster.Bag.Console.Commands;

public class AddressFind : Command
{
    public AddressFind() : base("address-find", "Finds multiple addresses")
    {
        AddOption(new Option<string>(new[] { "-p", "--postal-code" }));
        AddOption(new Option<int>(new[] { "-h", "--house-number" }));
        AddOption(new Option<string>(new[] { "-a", "--house-number-addition" }));
        AddOption(new Option<string>(new[] { "-l", "--house-number-letter" }));
        AddOption(new Option<string>(new[] { "-c", "--city" }));
        AddOption(new Option<string>(new[] { "-s", "--street" }));
        AddOption(new Option<string>(new[] { "-q", "--query" }));
        AddOption(new Option<bool>(new[] { "-e", "--exact-match" }));
        AddOption(new Option<string>(new[] { "--property-id" }));
        AddOption(new Option<string>(new[] { "--addressable-object-id" }));
    }

    public new class Handler : ICommandHandler
    {
        private readonly IAddressService _addressService;

        public Handler(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public string PropertyId { get; set; } // From DI
        public string AddressableObjectId { get; set; } // From DI

        public string PostalCode { get; set; } // From DI
        public int? HouseNumber { get; set; } // From DI
        public string HouseNumberAddition { get; set; } // From DI
        public string HouseNumberLetter { get; set; } // From DI
        public string City { get; set; } // From DI
        public string Street { get; set; } // From DI

        public string Query { get; set; } // From DI
        public bool? ExactMatch { get; set; } // From DI

        public int Invoke(InvocationContext context) => InvokeAsync(context).GetAwaiter().GetResult();

        public async Task<int> InvokeAsync(InvocationContext context)
        {
            var find = await Find();
            return find.On(addresses =>
            {
                if (addresses.Embedded != null)
                {
                    var lookup = new AddressLookup
                    {
                        Id = addresses.Embedded.Adressen[0].NummeraanduidingIdentificatie,
                        PostalCode = addresses.Embedded.Adressen[0].Postcode,
                        HouseNumber = addresses.Embedded.Adressen[0].Huisnummer ?? 0,
                        City = addresses.Embedded.Adressen[0].WoonplaatsNaam,
                        Street = addresses.Embedded.Adressen[0].OpenbareRuimteNaam
                    };

                    context.Console.Out.WriteLine(JsonSerializer.Serialize(lookup));

                    return 0;
                }

                context.Console.Error.WriteLine("No address found");

                return 1;
            }, error =>
            {
                if (error is BagException bagEx)
                {
                    context.Console.Error.WriteLine($"Error: {bagEx.Error.Title}");
                }
                else
                {
                    context.Console.Error.WriteLine($"Error: {error.Message}");
                }

                return 1;
            });
        }

        private Task<Result<AdresIOHalCollection>> Find()
        {
            if (!string.IsNullOrEmpty(PropertyId))
                return _addressService.FindByPropertyAsync(PropertyId);

            if (!string.IsNullOrEmpty(AddressableObjectId))
                return _addressService.FindByAddressableObjectAsync(AddressableObjectId);

            if (!string.IsNullOrEmpty(Query))
                return _addressService.FindAsync(Query);

            if (!string.IsNullOrEmpty(PostalCode) && HouseNumber != null)
                return _addressService.FindAsync(PostalCode, HouseNumber.Value, HouseNumberAddition, HouseNumberLetter, ExactMatch);

            if (!string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(Street) && HouseNumber != null)
                return _addressService.FindAsync(City, Street, HouseNumber.Value, HouseNumberAddition, HouseNumberLetter);

            var query = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(PostalCode)) query.Add("postcode", PostalCode);
            if (HouseNumber != null) query.Add("huisnummer", HouseNumber.Value.ToString());
            if (!string.IsNullOrEmpty(HouseNumberAddition)) query.Add("huisnummertoevoeging", HouseNumberAddition);
            if (!string.IsNullOrEmpty(HouseNumberLetter)) query.Add("huisletter", HouseNumberLetter);
            if (!string.IsNullOrEmpty(City)) query.Add("woonplaatsNaam", City);
            if (!string.IsNullOrEmpty(Street)) query.Add("openbareRuimteNaam", Street);

            if (!string.IsNullOrEmpty(PropertyId)) query.Add("pandIdentificatie", PropertyId);
            if (!string.IsNullOrEmpty(AddressableObjectId)) query.Add("adresseerbaarObjectIdentificatie", AddressableObjectId);
            if (!string.IsNullOrEmpty(Query)) query.Add("q", Query);

            if (ExactMatch != null) query.Add("exacteMatch", ExactMatch.Value.ToString().ToLowerInvariant());

            return _addressService.FindAsync(query);
        }
    }
}