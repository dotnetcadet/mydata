using System;
using System.IO;
using System.Collections.Generic;

namespace MyData.Clients;

public interface IClientRequest
{
    ClientRequestMethod Method { get; }
    IList<string> Paths { get; }
    IDictionary<string, string> Queries { get; }
    IDictionary<string, string> Headers { get; }
    Stream Body { get; }
}
