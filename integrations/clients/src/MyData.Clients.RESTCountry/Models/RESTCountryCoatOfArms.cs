using System;
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryCoatOfArms
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("png")]
    public Uri Png { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("svg")]
    public Uri Svg { get; set; }
}