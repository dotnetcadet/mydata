using System;
using System.Collections.Generic;

namespace MyData.Clients.UsCensus.Internal;

internal abstract class RequestBuilderBase
{
    public HashSet<string> Variables { get; } = new HashSet<string>()
    {
        "NAME"
    };

    public Dictionary<string, string> VariableMaps { get; } = new()
    {
        { "NAME", "Name" },
        { "state", "StateId" }
    };

    public required UsCensusClient Client { get; init; }
    public required UsCensusRequest Request { get; init; }
}
