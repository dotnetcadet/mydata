using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryFlags
{
    [JsonPropertyName("png")]
    public Uri? Png { get; set; }

    [JsonPropertyName("svg")]
    public Uri? Svg { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alt")]
    public string? Alt { get; set; }
}
