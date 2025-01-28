
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryCurrency
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }
}
