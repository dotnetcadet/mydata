using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyData.Databases;

public class DatabaseOptions
{
    public IServiceCollection Services { get; init; }
    public IConfigurationManager Configuration { get; init; }
    public IHostEnvironment Environment { get; set; }

}
