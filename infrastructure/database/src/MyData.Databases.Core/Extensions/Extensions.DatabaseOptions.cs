using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyData.Databases;

public static class DatabaseOptionsExtensions
{
    public static IHostApplicationBuilder AddMyDatabases(this IHostApplicationBuilder builder, Action<DatabaseOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(builder, nameof(builder));
        ArgumentNullException.ThrowIfNull(configure, nameof(configure));

        var options = new DatabaseOptions()
        {
            Services = builder.Services,
            Configuration = builder.Configuration,
            Environment = builder.Environment
        };

        configure.Invoke(options);

        builder.Services.AddSingleton<IRepositoryFactory>(serviceProvider =>
        {
            return default;
        });

        return builder;
    }
}
