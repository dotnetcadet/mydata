using System;
using System.Net.Http;

namespace MyData.Clients.UsCensus;

using Internal;

public class UsCensusClient : Client, IUsCensusClient
{
    UsCensusClient(UsCensusClientOptions options, HttpClient httpClient) : base(httpClient)
    {
        Endpoint = options.Endpoint;
    }

    public override string Name => nameof(IUsCensusClient);
    public override Uri Endpoint { get; }
    IUsDecennialCensusRequestBuilder IUsCensusClient.UseDecennialCensus(UsCensusYear year)
    {
        return new DecennialCensusRequestBuilderRequestBuilder()
        {
            Client = this,
            Request = new UsCensusRequest(Endpoint)
            {
                Path = GetYearPath(year) + "/dec",
                Method = ClientRequestMethod.Get
            }
        };
    }
    private string GetYearPath(UsCensusYear year) => year switch
    {
        UsCensusYear.Y2000 => "/data/2000",
        UsCensusYear.Y2010 => "/data/2010",
        UsCensusYear.Y2020 => "/data/2020",
        _ => throw new Exception()
    };
    public static IUsCensusClient Create(HttpClient httpClient, Action<UsCensusClientOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));
        ArgumentNullException.ThrowIfNull(configure, nameof(configure));

        var options = new UsCensusClientOptions();

        configure.Invoke(options);

        return new UsCensusClient(options, httpClient);
    }
}
