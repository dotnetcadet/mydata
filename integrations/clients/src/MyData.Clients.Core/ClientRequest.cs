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
        Paths = new List<string>();
        Queries = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        Body = new MemoryStream();
    }

    public Uri Endpoint { get; }
    public IList<string> Paths { get; }
    public IDictionary<string, string> Queries { get; }
    public IDictionary<string, string> Headers { get; }
    public Uri Uri
    {
        get
        {
            var uriBuilder = new UriBuilder(Endpoint);

            uriBuilder.Path = string.Join('/', Paths);
            uriBuilder.Query = string.Join('&', Queries.Select((key, value) => string.Join('=', key, value)));

            return uriBuilder.Uri;
        }
    }

    public Stream Body { get; }

    public required ClientRequestMethod Method { get; init; } = ClientRequestMethod.Get;
}
