using System;
using System.IO;

namespace MyData.Clients;

public abstract class ClientSuccess : ClientResponse
{
    public required Stream Body { get; init; }
}
