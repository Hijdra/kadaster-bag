using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.IO;
using System.Text.Json;
using Hya.Kadaster.Bag.Tool.Extensions;
using Hya.Kadaster.Bag.Tool.Models;
using Hya.Kadaster.Bag.Models;
using Hya.Kadaster.Bag.Models.Generated;
using Hya.Kadaster.Bag.Services;

namespace Hya.Kadaster.Bag.Tool.Commands;

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

        AddOption(new Option<int>(new[] { "--page" }));
        AddOption(new Option<int>(new[] { "--page-size" }));
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

        public int? Page { get; set; } // From DI
        public int? PageSize { get; set; } // From DI

        public int Invoke(InvocationContext context) => InvokeAsync(context).GetAwaiter().GetResult();

        public async Task<int> InvokeAsync(InvocationContext context)
        {
            var find = await Find();
            return find.HandleErrorState(
                context.Console,
                addresses =>
                {
                    if (addresses.Embedded is { Adressen.Count: > 0 })
                    {
                        var lookups = addresses.Embedded.Adressen
                            .Select(x => new AddressLookup
                            {
                                Id = x.NummeraanduidingIdentificatie,
                                PostalCode = x.Postcode,
                                HouseNumber = x.Huisnummer ?? 0,
                                City = x.WoonplaatsNaam,
                                Street = x.OpenbareRuimteNaam
                            });

                        context.Console.Out.WriteLine(JsonSerializer.Serialize(lookups));

                        return 0;
                    }

                    context.Console.Error.WriteLine("No address found");

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
                return _addressService.FindAsync(Query, Page, PageSize);

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

            if (Page != null) query.Add("page", Page.Value.ToString());
            if (PageSize != null) query.Add("pageSize", PageSize.Value.ToString());

            return _addressService.FindAsync(query);
        }
    }
}