using System;
using System.Collections.Generic;

namespace MyData.Clients;

public interface IClientResponse
{
    /// <summary>
    /// 
    /// </summary>
    int StatusCode { get; }

    /// <summary>
    /// 
    /// </summary>
    IDictionary<string, string> Meta { get; }
}
