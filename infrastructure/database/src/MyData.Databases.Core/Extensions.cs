using System;
using Microsoft.Extensions.Hosting;

namespace MyData.Databases;

public static class Extensions
{
    public static IHostApplicationBuilder AddMyDataDatabases(
        this IHostApplicationBuilder builder, 
        Action<MyDataDatabaseOptions> configure)
    {
        ArgumentNullException.ThrowIfNull(builder, nameof(builder));
        ArgumentNullException.ThrowIfNull(configure, nameof(configure));

        var options = new MyDataDatabaseOptions()
        {
            Services = builder.Services,
            Configuration = builder.Configuration,
            Environment = builder.Environment
        };

        configure.Invoke(options);

        return builder;
    }
}
