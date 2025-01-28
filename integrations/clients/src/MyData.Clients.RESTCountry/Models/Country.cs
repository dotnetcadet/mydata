using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json.Serialization;

namespace MyData.Clients.RESTCountry.Models;

public class Country
{
    [JsonPropertyName("name")]
    public Name Name { get; set; }

    [JsonPropertyName("tld")]
    public string[] Tld { get; set; }

    [JsonPropertyName("cca2")]
    public string Cca2 { get; set; }

    //[JsonPropertyName("ccn3")]
    ////[JsonConverter(typeof(ParseStringConverter))]
    //public string Ccn3 { get; set; }

    [JsonPropertyName("cca3")]
    public string Cca3 { get; set; }

    [JsonPropertyName("independent")]
    public bool Independent { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("unMember")]
    public bool UnMember { get; set; }

    [JsonPropertyName("currencies")]
    public Dictionary<string, Currency> Currencies { get; set; }

    [JsonPropertyName("idd")]
    public Idd Idd { get; set; }

    [JsonPropertyName("capital")]
    public string[] Capital { get; set; }

    [JsonPropertyName("altSpellings")]
    public string[] AltSpellings { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("languages")]
    public Languages Languages { get; set; }

    [JsonPropertyName("translations")]
    public Dictionary<string, Translation> Translations { get; set; }

    [JsonPropertyName("latlng")]
    public double[] Latlng { get; set; }

    [JsonPropertyName("landlocked")]
    public bool Landlocked { get; set; }

    [JsonPropertyName("area")]
    public double Area { get; set; }

    [JsonPropertyName("demonyms")]
    public Demonyms Demonyms { get; set; }

    [JsonPropertyName("flag")]
    public string Flag { get; set; }

    [JsonPropertyName("maps")]
    public Maps Maps { get; set; }

    [JsonPropertyName("population")]
    public long Population { get; set; }

    [JsonPropertyName("car")]
    public Car Car { get; set; }

    [JsonPropertyName("timezones")]
    public string[] Timezones { get; set; }

    [JsonPropertyName("continents")]
    public string[] Continents { get; set; }

    [JsonPropertyName("flags")]
    public Flags Flags { get; set; }

    //[JsonPropertyName("coatOfArms")]
    //public CoatOfArms CoatOfArms { get; set; }

    [JsonPropertyName("startOfWeek")]
    public string StartOfWeek { get; set; }

    [JsonPropertyName("capitalInfo")]
    public CapitalInfo CapitalInfo { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cioc")]
    public string Cioc { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subregion")]
    public string Subregion { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fifa")]
    public string Fifa { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("borders")]
    public string[] Borders { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gini")]
    public Gini Gini { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    public PostalCode PostalCode { get; set; }
}
