using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace MyData.Clients.Internal;

internal class ClientFactory : IClientFactory
{
    private readonly IServiceProvider serviceProvider;

    public ClientFactory(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public IClient Create(string name)
    {
        return GetClients().First(p => p.Name == name);
    }

    public TClient Create<TClient>() where TClient : IClient
    {
        return GetClients().OfType<TClient>().First();
    }

    public TClient Create<TClient>(string name) where TClient : IClient
    {
        return GetClients().OfType<TClient>().First(p=>p.Name == name);
    }

    private IEnumerable<IClient> GetClients()
    {
        return serviceProvider.GetRequiredService<IEnumerable<IClient>>();
    }
}
