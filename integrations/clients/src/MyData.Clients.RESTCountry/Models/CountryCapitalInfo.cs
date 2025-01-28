using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyData.Clients.RESTCountry.Models;

public partial class CapitalInfo
{
    [JsonPropertyName("latlng")]
    public double[] Latlng { get; set; }
}

public partial class Car
{
    [JsonPropertyName("signs")]
    public string[] Signs { get; set; }

    [JsonPropertyName("side")]
    public string Side { get; set; }
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

public partial class Currency
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }
}

public partial class Demonyms
{
    [JsonPropertyName("eng")]
    public Eng Eng { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fra")]
    public Eng Fra { get; set; }
}

public partial class Eng
{
    [JsonPropertyName("f")]
    public string F { get; set; }

    [JsonPropertyName("m")]
    public string M { get; set; }
}

public partial class Flags
{
    [JsonPropertyName("png")]
    public Uri Png { get; set; }

    [JsonPropertyName("svg")]
    public Uri Svg { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alt")]
    public string Alt { get; set; }
}

public partial class Gini
{
    [JsonPropertyName("2018")]
    public double The2018 { get; set; }
}

public partial class Idd
{
    [JsonPropertyName("root")]
    public string Root { get; set; }

    [JsonPropertyName("suffixes")]
    public string[] Suffixes { get; set; }
}

public partial class Languages
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eng")]
    public string Eng { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fra")]
    public string Fra { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gsw")]
    public string Gsw { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ita")]
    public string Ita { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roh")]
    public string Roh { get; set; }
}

public partial class Maps
{
    [JsonPropertyName("googleMaps")]
    public Uri GoogleMaps { get; set; }

    [JsonPropertyName("openStreetMaps")]
    public Uri OpenStreetMaps { get; set; }
}

public partial class Name
{
    [JsonPropertyName("common")]
    public string Common { get; set; }

    [JsonPropertyName("official")]
    public string Official { get; set; }

    [JsonPropertyName("nativeName")]
    public NativeName NativeName { get; set; }
}

public partial class NativeName
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eng")]
    public Translation Eng { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fra")]
    public Translation Fra { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gsw")]
    public Translation Gsw { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ita")]
    public Translation Ita { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roh")]
    public Translation Roh { get; set; }
}

public partial class Translation
{
    [JsonPropertyName("official")]
    public string Official { get; set; }

    [JsonPropertyName("common")]
    public string Common { get; set; }
}

public partial class PostalCode
{
    [JsonPropertyName("format")]
    public string Format { get; set; }
}