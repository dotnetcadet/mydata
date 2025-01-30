using System;
using System.IO;
using System.Collections.Generic;

namespace MyData.Clients;

public interface IClientRequest
{
    string? Path { get; }
    ClientRequestMethod Method { get; }
    IDictionary<string, string> Queries { get; }
    IDictionary<string, string> Headers { get; }
    Stream Body { get; }
}
