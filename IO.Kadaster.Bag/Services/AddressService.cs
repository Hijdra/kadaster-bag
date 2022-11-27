using IO.Kadaster.Bag.Extensions;
using IO.Kadaster.Bag.Models;
using IO.Kadaster.Bag.Models.Generated;

namespace IO.Kadaster.Bag.Services;

/// <summary>
/// Address Service
/// </summary>
/// <see href="https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres">Address</see>
public class AddressService : IAddressService
{
    private readonly HttpClient _client;

    public AddressService(HttpClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Find multiple addresses based on postalCode, houseNumber and optional params
    /// </summary>
    /// <see href="https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres/bevraagAdressen">Query Addresses</see>
    /// <param name="postCode">Postal Code</param>
    /// <param name="houseNumber">House Number</param>
    /// <param name="houseNumberAddition">House Number Addition</param>
    /// <param name="houseLetter">House Letter</param>
    /// <param name="exactMatch">Exact Match</param>
    /// <returns>Response of AdresIOHalCollection</returns>
    public async Task<Result<AdresIOHalCollection>> FindAsync(string postCode, string houseNumber, string houseNumberAddition = "", string houseLetter = "", bool? exactMatch = null)
    {
        var guard = Guard.New()
            .NotNull(postCode, $"{nameof(postCode)} is required")
            .NotNull(houseNumber,$"{nameof(houseNumber)} is required");
        if (guard.Exception != null) return guard;

        var query = new Dictionary<string, string>
        {
            ["postcode"] = postCode,
            ["huisnummer"] = houseNumber
        };

        if (!string.IsNullOrEmpty(houseNumberAddition)) query.Add("huisnummertoevoeging", houseNumberAddition);
        if (!string.IsNullOrEmpty(houseLetter)) query.Add("huisletter", houseLetter);
        if (exactMatch is true) query.Add("exacteMatch", "true");

        return await FindAsync(query);
    }

    /// <summary>
    /// Find multiple addresses based on queryParams (see Swagger doc)
    /// </summary>
    /// <see href="https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres/bevraagAdressen">Query Addresses</see>
    /// <param name="queryParams">Query params based on Swagger doc</param>
    /// <returns>Response of AdresIOHalCollection</returns>
    public async Task<Result<AdresIOHalCollection>> FindAsync(Dictionary<string, string> queryParams)
    {
        var guard = Guard.New()
            .NotNull(queryParams, $"{nameof(queryParams)} is required")
            .NotEmpty(queryParams, $"{nameof(queryParams)} is required");
        if (guard.Exception != null) return guard;
        
        var queryString = "?" + string.Join('&', queryParams.Select(x => $"{x.Key}={x.Value}"));
        var url = $"adressen{queryString}";

        var response = await _client.GetAsync(url);
        return await response.ToResultAsync<AdresIOHalCollection>();
    }
}