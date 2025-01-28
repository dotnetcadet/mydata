using System;
using System.Collections.Generic;
using System.Text;

namespace MyData.Clients;

public interface IClientRequest
{
    Uri Uri { get; }
}
