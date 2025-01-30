using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace MyData.Databases;

using Internal;

public static class DatabaseExtensions
{
    public static DatabaseOptions UseSqlServer(this DatabaseOptions options)
    {
        options.Services
            .AddPooledDbContextFactory<CoreContext>((serviceProvider, options) =>
            {
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                var connectionString = configuration["MyData:Databases:SqlServer:ConnectionString"];

                options.UseSqlServer(connectionString);
            });
            //.AddPooledDbContextFactory<BeaContext>(options =>
            //{
            //    options.UseSqlServer("");
            //})
            //.AddPooledDbContextFactory<CensusContext>(options =>
            //{
            //    options.UseSqlServer("");
            //})
            //.AddPooledDbContextFactory<FdaContext>(options =>
            //{
            //    options.UseSqlServer("");
            //});

        return options;
    }
}
