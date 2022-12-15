using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using Hya.Kadaster.Bag.Exceptions;
using Hya.Kadaster.Bag.Models;
using Hya.Kadaster.Bag.Models.Generated;

namespace Hya.Kadaster.Bag.Extensions;

internal static class HttpExtensions
{
    public static async Task<Result<T>> ToResultAsync<T>(this HttpResponseMessage responseMessage)
    {
        if (responseMessage.IsSuccessStatusCode)
        {
            var success = await responseMessage.Content.ReadFromJsonAsync<T>();
            if (success != null) return success;

            return new NotSupportedException("Success response is null");
        }

        if (responseMessage.Content.Headers.ContentType?.MediaType == "text/html")
        {
            var html = await responseMessage.Content.ReadAsStringAsync();
            if (html.Contains("Missing API Key"))
                return new ArgumentException("Missing API Key");

            return new NotSupportedException("API returned HTML with unknown contents");
        }

        var error = await responseMessage.Content.ReadFromJsonAsync<Error>();
        return error == null
            ? new NotSupportedException("Error response is null")
            : new BagException(error);
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