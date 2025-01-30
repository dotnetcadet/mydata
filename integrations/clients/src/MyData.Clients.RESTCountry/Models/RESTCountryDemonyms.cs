using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry;

public partial class RESTCountryDemonyms
{
    [JsonPropertyName("eng")]
    public RESTCountryEng? Eng { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fra")]
    public RESTCountryEng? Fra { get; set; }
}