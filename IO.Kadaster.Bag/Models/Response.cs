using System.Net;
using System.Net.Http.Headers;
using IO.Kadaster.Bag.Models.Generated;

namespace IO.Kadaster.Bag.Models;

public class Response<T>
{
    public bool Ok { get; set; }
    public HttpStatusCode Status { get; set; }
    public string? Reason { get; set; }
    public HttpResponseHeaders Headers { get; set; }
    public T? Object { get; set; }
    public Error? Error { get; set; }
}