using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public class RESTCountryClientOptions
{
    public Version Version { get; set; } = new Version(3, 1);
    public Uri Endpoint { get; set; } = new Uri("https://restcountries.com");
}
