using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryTranslation
{
    [JsonPropertyName("official")]
    public string? Official { get; set; }

    [JsonPropertyName("common")]
    public string? Common { get; set; }
}