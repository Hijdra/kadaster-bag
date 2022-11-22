using RichardSzalay.MockHttp;

namespace IO.Kadaster.Bag.Tests;

internal static class TestExtensions
{
    public static HttpClient ToBagHttpClient(this MockHttpMessageHandler messageHandler)
    {
        var client = messageHandler.ToHttpClient();
        client.BaseAddress = new Uri("http://localhost/");
        client.DefaultRequestHeaders.Add("X-Api-Key", "TOKEN");
        return client;
    }
}