using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyData.Clients;

public class ClientOptions
{
    public IServiceCollection Services { get; init; } = default!;
    public IConfigurationManager Configuration { get; init; } = default!;
}
