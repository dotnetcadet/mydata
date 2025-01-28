using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public class RESTCountryClientResponse<T> : IClientResponse
{
    public int Status { get; init; }
    public required T Data { get; init; }
    object? IClientResponse.Data => Data;
}
