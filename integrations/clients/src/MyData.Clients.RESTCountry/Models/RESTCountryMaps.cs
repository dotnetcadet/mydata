using System;
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryMaps
{
    [JsonPropertyName("googleMaps")]
    public Uri? GoogleMaps { get; set; }

    [JsonPropertyName("openStreetMaps")]
    public Uri? OpenStreetMaps { get; set; }
}
