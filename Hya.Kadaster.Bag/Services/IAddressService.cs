using Hya.Kadaster.Bag.Models;
using Hya.Kadaster.Bag.Models.Generated;

namespace Hya.Kadaster.Bag.Services;

public interface IAddressService
{
    Task<Result<AdresIOHalCollection>> FindAsync(string postCode, string houseNumber, string houseNumberAddition = "", string houseLetter = "", bool? exactMatch = null);
    Task<Result<AdresIOHalCollection>> FindAsync(Dictionary<string, string> queryParams);
}