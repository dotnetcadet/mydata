using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace MyData.Clients;

using Internal;

public static class HostApplicationBuilderExtensions
{
    public static IHostApplicationBuilder AddMyClients(this IHostApplicationBuilder builder, Action<ClientOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(builder, nameof(builder));
        ArgumentNullException.ThrowIfNull(configure, nameof(configure));

        var options = new ClientOptions()
        {
            Services = builder.Services,
            Configuration = builder.Configuration
        };

        configure.Invoke(options);

        builder.Services.AddHttpClient();
        builder.Services.AddSingleton<IClientFactory, ClientFactory>();

        return builder;
    }
}
