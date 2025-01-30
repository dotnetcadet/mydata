using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace MyData.Clients;

public class ClientRequest : IClientRequest
{
    public ClientRequest(Uri endpoint)
    {
        Endpoint = endpoint;
        Queries = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        Body = new MemoryStream();
    }

    public Uri Endpoint { get; }
    public string? Path { get; set; }
    public IDictionary<string, string> Queries { get; }
    public IDictionary<string, string> Headers { get; }
    public Uri Uri
    {
        get
        {
            var uriBuilder = new UriBuilder(Endpoint);

            uriBuilder.Path = Path;
            uriBuilder.Query = string.Join('&', [..Queries.Select((query) => string.Join('=', query.Key, query.Value))]);

            return uriBuilder.Uri;
        }
    }

    public Stream Body { get; }

    public required ClientRequestMethod Method { get; set; } = ClientRequestMethod.Get;
}
