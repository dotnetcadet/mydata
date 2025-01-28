using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryEng
{
    [JsonPropertyName("f")]
    public string F { get; set; }

    [JsonPropertyName("m")]
    public string M { get; set; }
}
