using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.UsCensus;

public sealed class UsCensusClientOptions
{
    public string? ApiKey { get; set; }
    public Uri Endpoint { get; set; } = new Uri("https://api.census.gov/");
}
