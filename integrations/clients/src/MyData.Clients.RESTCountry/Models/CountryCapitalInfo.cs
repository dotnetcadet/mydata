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



public partial class CoatOfArms
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("png")]
    public Uri Png { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("svg")]
    public Uri Svg { get; set; }
}



public partial class Demonyms
{
    [JsonPropertyName("eng")]
    public RESTCountryEng? Eng { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fra")]
    public RESTCountryEng? Fra { get; set; }
}


public partial class Gini
{
    [JsonPropertyName("2018")]
    public double The2018 { get; set; }
}
