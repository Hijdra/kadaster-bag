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
    /// <param name="queryParams">Query params based on Swagger doc</param>
    /// <returns>Response of AdresIOHalCollection</returns>
    public async Task<Response<AdresIOHalCollection>> FindAsync(string postCode, string houseNumber, string houseNumberAddition = "", string houseLetter = "", bool? exactMatch = null)
    {
        if (string.IsNullOrEmpty(postCode)) throw new ArgumentNullException(nameof(postCode), $"{nameof(postCode)} is required");
        if (string.IsNullOrEmpty(houseNumber)) throw new ArgumentNullException(nameof(houseNumber), $"{nameof(houseNumber)} is required");

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
    public async Task<Response<AdresIOHalCollection>> FindAsync(Dictionary<string, string> queryParams)
    {
        var queryString = "?" + string.Join('&', queryParams.Select(x => $"{x.Key}={x.Value}"));
        var url = $"adressen{queryString}";

        var response = await _client.GetAsync(url);
        return await response.ToResponseAsync<AdresIOHalCollection>();
    }
}