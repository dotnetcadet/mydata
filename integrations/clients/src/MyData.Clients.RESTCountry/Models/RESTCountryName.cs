using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryName
{
    [JsonPropertyName("common")]
    public string? Common { get; set; }

    [JsonPropertyName("official")]
    public string? Official { get; set; }

    [JsonPropertyName("nativeName")]
    public RESTCountryNativeName? NativeName { get; set; }
}
