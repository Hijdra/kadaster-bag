using System.Net;
using Hya.Kadaster.Bag.Exceptions;
using Hya.Kadaster.Bag.Services;
using RichardSzalay.MockHttp;

namespace Hya.Kadaster.Bag.Tests.Services;

public class AddressTest
{
    private readonly string _findAsyncJsonResponseOk =
        "{\"_links\":{\"self\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/adressen?postcode=1011PN&huisnummer=1\"}},\"_embedded\":{\"adressen\":[{\"openbareRuimteNaam\":\"Amstel\",\"korteNaam\":\"Amstel\",\"huisnummer\":1,\"postcode\":\"1011PN\",\"woonplaatsNaam\":\"Amsterdam\",\"nummeraanduidingIdentificatie\":\"0363200012145295\",\"openbareRuimteIdentificatie\":\"0363300000002701\",\"woonplaatsIdentificatie\":\"3594\",\"adresseerbaarObjectIdentificatie\":\"0363010012143319\",\"pandIdentificaties\":[\"0363100012186092\"],\"adresregel5\":\"Amstel 1\",\"adresregel6\":\"1011 PN  AMSTERDAM\",\"_links\":{\"self\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/adressen/0363200012145295\"},\"openbareRuimte\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/openbareruimten/0363300000002701\"},\"nummeraanduiding\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/nummeraanduidingen/0363200012145295\"},\"woonplaats\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/woonplaatsen/3594\"},\"adresseerbaarObject\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/verblijfsobjecten/0363010012143319\"},\"panden\":[{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/panden/0363100012186092\"}]}}]}}";

    private readonly string _findAsyncJsonResponseNotFound = "{\"_links\":{\"self\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/adressen?postcode=1011PN&huisnummer=2\"}}}";

    private readonly string _getAsyncJsonResponseOk =
        "{\"openbareRuimteNaam\":\"Amstel\",\"korteNaam\":\"Amstel\",\"huisnummer\":1,\"postcode\":\"1011PN\",\"woonplaatsNaam\":\"Amsterdam\",\"nummeraanduidingIdentificatie\":\"0363200012145295\",\"openbareRuimteIdentificatie\":\"0363300000002701\",\"woonplaatsIdentificatie\":\"3594\",\"adresseerbaarObjectIdentificatie\":\"0363010012143319\",\"pandIdentificaties\":[\"0363100012186092\"],\"adresregel5\":\"Amstel 1\",\"adresregel6\":\"1011 PN  AMSTERDAM\",\"_links\":{\"self\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/adressen/0363200012145295\"},\"openbareRuimte\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/openbareruimten/0363300000002701\"},\"nummeraanduiding\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/nummeraanduidingen/0363200012145295\"},\"woonplaats\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/woonplaatsen/3594\"},\"adresseerbaarObject\":{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/verblijfsobjecten/0363010012143319\"},\"panden\":[{\"href\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/panden/0363100012186092\"}]} }";

    private readonly string _getAsyncJsonResponseNotFound = "{\"status\":404,\"title\":\"Opgevraagde resource bestaat niet.\",\"type\":\"https://tools.ietf.org/html/rfc7231#section-6.5.4\",\"detail\":\"Geen nummeraanduiding gevonden met id 0363200012145291\",\"instance\":\"https://api.bag.kadaster.nl/lvbag/individuelebevragingen/v2/adressen/0363200012145291\",\"code\":\"notFound\"}";

    [Theory]
    [InlineData("1011PN")]
    [InlineData("1011 PN")]
    [InlineData("1011pn")]
    [InlineData("1011 pn")]
    [InlineData(" 1011PN")]
    [InlineData("1011PN ")]
    [InlineData(" 1011PN ")]
    public async Task FindAsync_PostCodeAndHouseNumber_Ok(string identifier)
    {
        // Arrange
        var houseNumber = 1;

        var mockHttp = new MockHttpMessageHandler();
        mockHttp
            .When($"http://localhost/adressen?postcode={identifier.Trim()}&huisnummer={houseNumber}")
            .Respond("application/json", _findAsyncJsonResponseOk);

        var client = mockHttp.ToBagHttpClient();
        var address = new AddressService(client);
        // Act
        var result = await address.FindAsync(identifier, houseNumber);

        // Assert
        Assert.NotNull(result);
        result.On(value =>
        {
            Assert.NotNull(value);
            Assert.NotNull(value.Embedded);
            Assert.NotNull(value.Embedded.Adressen);
            Assert.Single(value.Embedded.Adressen);
            Assert.Equal("1011PN", value.Embedded.Adressen[0].Postcode);
            Assert.Equal(houseNumber, value.Embedded.Adressen[0].Huisnummer);
            Assert.Equal("Amstel", value.Embedded.Adressen[0].KorteNaam);
            Assert.Equal("Amsterdam", value.Embedded.Adressen[0].WoonplaatsNaam);
        }, error => { Assert.Fail("Should not enter here"); });
    }

    [Fact]
    public async Task FindAsync_PostCodeAndHouseNumber_NotFound()
    {
        // Arrange
        var postCode = "1011PN";
        var houseNumber = 2;

        var mockHttp = new MockHttpMessageHandler();
        mockHttp
            .When($"http://localhost/adressen?postcode={postCode}&huisnummer={houseNumber}")
            .Respond("application/json", _findAsyncJsonResponseNotFound);

        var client = mockHttp.ToBagHttpClient();
        var address = new AddressService(client);
        // Act
        var result = await address.FindAsync(postCode, houseNumber);

        // Assert
        Assert.NotNull(result);
        result.On(value =>
        {
            Assert.NotNull(value);
            Assert.Null(value.Embedded);
        }, error => { Assert.Fail("Should not enter here"); });
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("    ")]
    public async Task FindAsync_PostCodeAndHouseNumber_ArgumentNullException(string postCode)
    {
        // Arrange
        var houseNumber = 1;

        var mockHttp = new MockHttpMessageHandler();
        mockHttp
            .When($"http://localhost/adressen?postcode={postCode}&huisnummer={houseNumber}")
            .Respond("application/json", _findAsyncJsonResponseOk);

        var client = mockHttp.ToBagHttpClient();
        var address = new AddressService(client);
        // Act
        var result = await address.FindAsync(postCode, houseNumber);

        // Assert
        Assert.NotNull(result);
        result.On(value => { Assert.Fail("Should not enter here"); }, error =>
        {
            if (error is not ArgumentNullException)
            {
                Assert.Fail("Does not return an ArgumentNullException");
            }
        });
    }

    [Theory]
    [InlineData("1011", 1)]
    [InlineData("1011  PN", 1)]
    [InlineData("12345", 1)]
    [InlineData("hello", 1)]
    [InlineData("123PN", 1)]
    [InlineData("1234AB", -1)]
    [InlineData("1234AB", 0)]
    [InlineData("1234AB", 100000)]
    public async Task FindAsync_PostCodeAndHouseNumber_ArgumentException(string postCode, int houseNumber)
    {
        // Arrange
        var mockHttp = new MockHttpMessageHandler();
        mockHttp
            .When($"http://localhost/adressen?postcode={postCode}&huisnummer={houseNumber}")
            .Respond("application/json", _findAsyncJsonResponseOk);

        var client = mockHttp.ToBagHttpClient();
        var address = new AddressService(client);
        // Act
        var result = await address.FindAsync(postCode, houseNumber);

        // Assert
        Assert.NotNull(result);
        result.On(value => { Assert.Fail("Should not enter here"); }, error =>
        {
            if (error is not ArgumentException)
            {
                Assert.Fail("Does not return an ArgumentException");
            }
        });
    }
    
    [Theory]
    [InlineData("0363200012145295")]
    [InlineData(" 0363200012145295")]
    [InlineData("0363200012145295 ")]
    [InlineData(" 0363200012145295 ")]
    public async Task GetAsync_Identifier_Ok(string identifier)
    {
        // Arrange
        var mockHttp = new MockHttpMessageHandler();
        mockHttp
            .When($"http://localhost/adressen/{identifier.Trim()}")
            .Respond("application/json", _getAsyncJsonResponseOk);

        var client = mockHttp.ToBagHttpClient();
        var address = new AddressService(client);
        // Act
        var result = await address.GetAsync(identifier);

        // Assert
        Assert.NotNull(result);
        result.On(value =>
        {
            Assert.NotNull(value);
            Assert.Equal("1011PN", value.Postcode);
            Assert.Equal(1, value.Huisnummer);
            Assert.Equal("Amstel", value.KorteNaam);
            Assert.Equal("Amsterdam", value.WoonplaatsNaam);
        }, error => { Assert.Fail("Should not enter here"); });
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("    ")]
    public async Task GetAsync_Identifier_ArgumentNullException(string identifier)
    {
        // Arrange
        var mockHttp = new MockHttpMessageHandler();
        mockHttp
            .When($"http://localhost/adressen/{identifier}")
            .Respond("application/json", _getAsyncJsonResponseOk);

        var client = mockHttp.ToBagHttpClient();
        var address = new AddressService(client);
        // Act
        var result = await address.GetAsync(identifier);

        // Assert
        Assert.NotNull(result);
        result.On(value => { Assert.Fail("Should not enter here"); }, error =>
        {
            if (error is not ArgumentNullException)
            {
                Assert.Fail("Does not return an ArgumentNullException");
            }
        });
    }

    [Fact]
    public async Task GetAsync_Identifier_BagException()
    {
        // Arrange
        var identifier = "0363200012145291";
        
        var mockHttp = new MockHttpMessageHandler();
        mockHttp
            .When($"http://localhost/adressen/{identifier}")
            .Respond(HttpStatusCode.NotFound,"application/json", _getAsyncJsonResponseNotFound);

        var client = mockHttp.ToBagHttpClient();
        var address = new AddressService(client);
        // Act
        var result = await address.GetAsync(identifier);

        // Assert
        Assert.NotNull(result);
        result.On(value => { Assert.Fail("Should not enter here"); }, error =>
        {
            if (error is not BagException)
            {
                Assert.Fail("Does not return an BagException");
            }
        });
    }
}