using System;
using System.Collections.Generic;
using System.Text;

namespace MyData.Clients;

public interface IClientResponse
{
    int Status { get; }
    object? Data { get; }
}
