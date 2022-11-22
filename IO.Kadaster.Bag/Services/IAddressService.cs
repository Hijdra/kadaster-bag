using IO.Kadaster.Bag.Models;
using IO.Kadaster.Bag.Models.Generated;

namespace IO.Kadaster.Bag.Services;

public interface IAddressService
{
    Task<Response<AdresIOHalCollection>> FindAsync(string postCode, string houseNumber, string houseNumberAddition = "", string houseLetter = "", bool? exactMatch = null);
    Task<Response<AdresIOHalCollection>> FindAsync(Dictionary<string, string> queryParams);
}