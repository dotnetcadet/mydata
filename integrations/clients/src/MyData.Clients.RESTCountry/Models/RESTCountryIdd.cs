using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryIdd
{
    [JsonPropertyName("root")]
    public string? Root { get; set; }

    [JsonPropertyName("suffixes")]
    public string[]? Suffixes { get; set; }
}
