using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryCar
{
    [JsonPropertyName("signs")]
    public string[]? Signs { get; set; }

    [JsonPropertyName("side")]
    public string? Side { get; set; }
}
