namespace Hya.Kadaster.Bag.Tool.Models;

public class AddressDto
{
    public string Id { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Street { get; set; }
    public int HouseNumber { get; set; }
    public string HouseNumberAddition { get; set; }
    public string HouseLetter { get; set; }
}