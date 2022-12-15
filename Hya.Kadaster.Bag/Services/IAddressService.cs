using Hya.Kadaster.Bag.Models;
using Hya.Kadaster.Bag.Models.Generated;

namespace Hya.Kadaster.Bag.Services;

public interface IAddressService
{
    Task<Result<AdresIOHalCollection>> FindAsync(string search, int? page = 1, int? pageSize = 20);
    Task<Result<AdresIOHalCollection>> FindAsync(string city, string street, int houseNumber, string houseNumberAddition = "", string houseLetter = "");
    Task<Result<AdresIOHalCollection>> FindAsync(string postCode, int houseNumber, string houseNumberAddition = "", string houseLetter = "", bool? exactMatch = null);
    Task<Result<AdresIOHalCollection>> FindAsync(Dictionary<string, string> queryParams);
    Task<Result<AdresIOHalCollection>> FindByPropertyAsync(string propertyId);
    Task<Result<AdresIOHalCollection>> FindByAddressableObjectAsync(string addressableObjectId);
    Task<Result<AdresIOHal>> GetAsync(string identifier);
}