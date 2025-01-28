

namespace MyData.Clients.RESTCountry;

public class RESTCountryClientRequest : IClientRequest
{
    public required string Version { get; init; }
    public required string Path { get; init; }
    public string Query { get; init; }
    public required string Endpoint { get; set; }

    public Uri Uri
    {
        get
        {
            var uriBuilder = new UriBuilder(Endpoint);

            uriBuilder.Path = $"v{Version}/{Path}";
            uriBuilder.Query = Query;

            return uriBuilder.Uri;
        }
    }
}
