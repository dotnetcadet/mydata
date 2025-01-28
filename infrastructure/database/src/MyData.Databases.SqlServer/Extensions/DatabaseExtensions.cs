using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyData.Databases;

using Internal;

public static class DatabaseExtensions
{
    public static DatabaseOptions UseSqlServer(this DatabaseOptions options)
    {
        options.Services
            .AddPooledDbContextFactory<CoreContext>(options =>
            {
                options.UseSqlServer("");
            })
            .AddPooledDbContextFactory<BeaContext>(options =>
            {
                options.UseSqlServer("");
            })
            .AddPooledDbContextFactory<CensusContext>(options =>
            {
                options.UseSqlServer("");
            })
            .AddPooledDbContextFactory<FdaContext>(options =>
            {
                options.UseSqlServer("");
            });

        return options;
    }
}
