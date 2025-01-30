using System;

namespace MyData.Clients.UsCensus.Internal;

internal class DecennialCensusRequestBuilderRequestBuilder : RequestBuilderBase, IUsDecennialCensusRequestBuilder
{
    public IUsDecennialCensusDemographicProfileRequestBuilder WithDemographicProfile()
    {
        Request.Path = string.Join('/', Request.Path, "dp");
        
        return new DecennialCensusDemographicProfileRequestBuilder()
        {
            Client = this.Client,
            Request = this.Request
        };
    }
}
