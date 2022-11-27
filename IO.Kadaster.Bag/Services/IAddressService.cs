using IO.Kadaster.Bag.Models;
using IO.Kadaster.Bag.Models.Generated;

namespace IO.Kadaster.Bag.Services;

public interface IAddressService
{
    Task<Result<AdresIOHalCollection>> FindAsync(string postCode, string houseNumber, string houseNumberAddition = "", string houseLetter = "", bool? exactMatch = null);
    Task<Result<AdresIOHalCollection>> FindAsync(Dictionary<string, string> queryParams);
}