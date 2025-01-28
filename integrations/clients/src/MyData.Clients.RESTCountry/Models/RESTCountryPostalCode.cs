using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryPostalCode
{
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}
