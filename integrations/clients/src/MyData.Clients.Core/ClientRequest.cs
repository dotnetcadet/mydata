using System;
using System.Collections.Generic;
using System.IO;

namespace MyData.Clients;

public class ClientRequest : IClientRequest
{
    public ClientRequest()
    {
        Paths = new List<string>();
        Queries = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        Headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        Body = new MemoryStream();
    }

    public IList<string> Paths { get; }

    public IDictionary<string, string> Queries { get; }

    public IDictionary<string, string> Headers { get; }

    public Stream Body { get; }

    public required ClientRequestMethod Method { get; init; } = ClientRequestMethod.Get;
}
