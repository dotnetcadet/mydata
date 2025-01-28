using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace MyData.Clients;

using MyData.Clients.RESTCountry;

public static class ClientOptionsExtensions
{
    public static ClientOptions UseRESTCountryClient(this ClientOptions options)
    {
        return UseRESTCountryClient(options, (sp, ops) => { });
    }
    public static ClientOptions UseRESTCountryClient(this ClientOptions options, Action<RESTCountryClientOptions> configure)
    {
        return UseRESTCountryClient(options, (sp, ops) => configure.Invoke(ops));
    }

    public static ClientOptions UseRESTCountryClient(this ClientOptions options, Action<IServiceProvider, RESTCountryClientOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(options, nameof(options));
        ArgumentNullException.ThrowIfNull(configure, nameof(configure));

        options.Services.TryAddScoped<IRESTCountryClient>(serviceProvider =>
        {
            var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
            var httpClient = httpClientFactory.CreateClient(nameof(IRESTCountryClient));

            Action<RESTCountryClientOptions> action = (options) =>
            {
                configure.Invoke(serviceProvider, options);
            };

            return RESTCountryClient.Create(httpClient, action);
        });

        return options;
    }
}
