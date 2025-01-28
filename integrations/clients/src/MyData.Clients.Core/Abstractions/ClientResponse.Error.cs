using System;
using System.Diagnostics;

namespace MyData.Clients;

[DebuggerDisplay("{Status}: {Message}")]
public abstract class ClientError : ClientResponse
{
    protected ClientError(int statusCode)
    {
        if (statusCode > 599 || statusCode < 400)
        {
            throw new ArgumentException("Status Code mus be between 400 and 599");
        }
        StatusCode = statusCode;
    }

    public abstract string Message { get; }
}
