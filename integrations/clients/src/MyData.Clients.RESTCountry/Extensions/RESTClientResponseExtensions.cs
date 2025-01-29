using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public static class RESTClientResponseExtensions
{
    public static string GetRESTCountrySource(this IClientResponse response)
    {
        return response.Meta["Source"];
    }
}
