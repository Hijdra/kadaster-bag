using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using IO.Kadaster.Bag.Models;
using IO.Kadaster.Bag.Models.Generated;

namespace IO.Kadaster.Bag.Extensions;

internal static class HttpExtensions
{
    public static async Task<Response<T>> ToResponseAsync<T>(this HttpResponseMessage responseMessage)
    {
        var response = new Response<T>
        {
            Ok = responseMessage.IsSuccessStatusCode,
            Status = responseMessage.StatusCode,
            Reason = responseMessage.ReasonPhrase,
            Headers = responseMessage.Headers
        };

        if (responseMessage.IsSuccessStatusCode)
            response.Object = await responseMessage.Content.ReadFromJsonAsync<T>();
        else
            response.Error = await responseMessage.Content.ReadFromJsonAsync<Error>();

        return response;
    }
    
    public static StringContent ToJsonRequest<T>(this T request)
    {
        var json = JsonSerializer.Serialize(request);
        return new StringContent(json)
        {
            Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
        };
    }
}