using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryCapitalInfo
{
    [JsonPropertyName("latlng")]
    public double[]? Latlng { get; set; }
}