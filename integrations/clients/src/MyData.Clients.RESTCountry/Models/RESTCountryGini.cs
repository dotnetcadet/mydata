using System;
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;


public partial class RESTCountryGini
{
    [JsonPropertyName("2018")]
    public double The2018 { get; set; }
}
