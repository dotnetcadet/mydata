using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MyData.Clients.UsCensus;

public static class UsCensusClientOptionsExtensions
{
    public static ClientOptions UseCensusClient(this ClientOptions options)
    {
        return UseCensusClient(options, (sp, ops) => { });
    }
    public static ClientOptions UseCensusClient(this ClientOptions options, Action<UsCensusClientOptions> configure)
    {
        return UseCensusClient(options, (sp, ops) => configure.Invoke(ops));
    }

    public static ClientOptions UseCensusClient(this ClientOptions options, Action<IServiceProvider, UsCensusClientOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(options, nameof(options));
        ArgumentNullException.ThrowIfNull(configure, nameof(configure));

        options.Services.TryAddScoped<IClient>(serviceProvider =>
        {
            var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
            var httpClient = httpClientFactory.CreateClient(nameof(IUsCensusClient));

            Action<UsCensusClientOptions> action = (options) =>
            {
                configure.Invoke(serviceProvider, options);
            };

            return UsCensusClient.Create(httpClient, action);
        });

        return options;
    }
}
