using Hya.Kadaster.Bag.Extensions;
using Hya.Kadaster.Bag.Models;
using Hya.Kadaster.Bag.Models.Generated;

namespace Hya.Kadaster.Bag.Services;

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
    /// <param name="search">Search</param>
    /// <returns>Response of AdresIOHalCollection</returns>
    public async Task<Result<AdresIOHalCollection>> FindAsync(string search)
    {
        search = search?.Trim();

        var guard = Guard.New()
            .NotNullOrEmpty(search, $"{nameof(search)} is required");
        if (guard.Exception != null) return guard;

        var query = new Dictionary<string, string>
        {
            ["q"] = search
        };

        return await FindAsync(query);
    }

    /// <summary>
    /// Find multiple addresses based on postalCode, houseNumber and optional params
    /// </summary>
    /// <see href="https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres/bevraagAdressen">Query Addresses</see>
    /// <param name="city">City</param>
    /// <param name="street">Street</param>
    /// <param name="houseNumber">House Number</param>
    /// <param name="houseNumberAddition">House Number Addition</param>
    /// <param name="houseLetter">House Letter</param>
    /// <returns>Response of AdresIOHalCollection</returns>
    public async Task<Result<AdresIOHalCollection>> FindAsync(string city, string street, int houseNumber, string houseNumberAddition = "", string houseLetter = "")
    {
        city = city?.Trim();
        street = street?.Trim();
        houseNumberAddition = houseNumberAddition?.Trim();
        houseLetter = houseLetter?.Trim();

        var guard = Guard.New()
            .NotNullOrEmpty(city, $"{nameof(city)} is required")
            .NotNullOrEmpty(street, $"{nameof(street)} is required")
            .NotRange(houseNumber, 1, 99999, $"{nameof(houseNumber)} is not in range between 1 and 99999");
        if (guard.Exception != null) return guard;

        var query = new Dictionary<string, string>
        {
            ["woonplaatsNaam"] = city,
            ["openbareRuimteNaam"] = street,
            ["huisnummer"] = houseNumber.ToString()
        };

        if (!string.IsNullOrEmpty(houseNumberAddition)) query.Add("huisnummertoevoeging", houseNumberAddition);
        if (!string.IsNullOrEmpty(houseLetter)) query.Add("huisletter", houseLetter);

        return await FindAsync(query);
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
    public async Task<Result<AdresIOHalCollection>> FindAsync(string postCode, int houseNumber, string houseNumberAddition = "", string houseLetter = "", bool? exactMatch = null)
    {
        postCode = postCode?.Trim();
        houseNumberAddition = houseNumberAddition?.Trim();
        houseLetter = houseLetter?.Trim();

        var guard = Guard.New()
            .NotNullOrEmpty(postCode, $"{nameof(postCode)} is required")
            .NotDutchPostalCode(postCode)
            .NotRange(houseNumber, 1, 99999, $"{nameof(houseNumber)} is not in range between 1 and 99999");
        if (guard.Exception != null) return guard;

        var query = new Dictionary<string, string>
        {
            ["postcode"] = postCode,
            ["huisnummer"] = houseNumber.ToString()
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
            .NotAny(queryParams, $"{nameof(queryParams)} is required");
        if (guard.Exception != null) return guard;

        var queryString = "?" + string.Join('&', queryParams.Select(x => $"{x.Key}={x.Value}"));
        var url = $"adressen{queryString}";

        var response = await _client.GetAsync(url);
        return await response.ToResultAsync<AdresIOHalCollection>();
    }

    /// <summary>
    /// Find multiple addresses based on postalCode, houseNumber and optional params
    /// </summary>
    /// <see href="https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres/bevraagAdressen">Query Addresses</see>
    /// <param name="propertyId">Search</param>
    /// <returns>Response of AdresIOHalCollection</returns>
    public async Task<Result<AdresIOHalCollection>> FindByPropertyAsync(string propertyId)
    {
        propertyId = propertyId?.Trim();

        var guard = Guard.New()
            .NotNullOrEmpty(propertyId, $"{nameof(propertyId)} is required");
        if (guard.Exception != null) return guard;

        var query = new Dictionary<string, string>
        {
            ["pandIdentificatie"] = propertyId
        };

        return await FindAsync(query);
    }

    /// <summary>
    /// Find multiple addresses based on postalCode, houseNumber and optional params
    /// </summary>
    /// <see href="https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres/bevraagAdressen">Query Addresses</see>
    /// <param name="addressableObjectId">Search</param>
    /// <returns>Response of AdresIOHalCollection</returns>
    public async Task<Result<AdresIOHalCollection>> FindByAddressableObjectAsync(string addressableObjectId)
    {
        addressableObjectId = addressableObjectId?.Trim();

        var guard = Guard.New()
            .NotNullOrEmpty(addressableObjectId, $"{nameof(addressableObjectId)} is required");
        if (guard.Exception != null) return guard;

        var query = new Dictionary<string, string>
        {
            ["adresseerbaarObjectIdentificatie"] = addressableObjectId
        };

        return await FindAsync(query);
    }

    /// <summary>
    /// Get address based on the identifier (see Swagger doc)
    /// </summary>
    /// <see href="https://lvbag.github.io/BAG-API/Technische%20specificatie/#/Adres/bevraagAdressenMetNumId">Get Address</see>
    /// <param name="identifier">Identifier for the Address</param>
    /// <returns>Response of AdresIOHal</returns>
    public async Task<Result<AdresIOHal>> GetAsync(string identifier)
    {
        identifier = identifier?.Trim();
        
        var guard = Guard.New()
            .NotNullOrEmpty(identifier, $"{nameof(identifier)} is required");
        if (guard.Exception != null) return guard;

        var url = $"adressen/{identifier}";

        var response = await _client.GetAsync(url);
        return await response.ToResultAsync<AdresIOHal>();
    }
}