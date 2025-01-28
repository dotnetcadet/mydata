using System;
using System.Collections.Generic;

namespace MyData.Clients;

public abstract class ClientResponse : IClientResponse
{
    protected ClientResponse()
    {
        Meta = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    }

    /// <summary>
    /// 
    /// </summary>
    public int StatusCode { get; init; }

    /// <summary>
    /// 
    /// </summary>
    public virtual IDictionary<string, string> Meta { get; }
}
