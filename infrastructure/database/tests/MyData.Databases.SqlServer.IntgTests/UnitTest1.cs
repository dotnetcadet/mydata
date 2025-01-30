
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MyData.Databases.IntgTests;

public class UnitTest1
{
    private readonly IServiceProvider serviceProvider;

    public UnitTest1()
    {
        serviceProvider = new ServiceCollection()
            .AddPooledDbContextFactory<CoreContext>(options =>
            {
                options.UseSqlServer("Server=localhost;Database=MyData;User Id=sa;Password=Kg<j>aie48934!245jf;TrustServerCertificate=True");
            })
            .BuildServiceProvider();
    }


    [Fact]
    public void Test1()
    {
        var dbContextFactory = serviceProvider.GetRequiredService<IDbContextFactory<CoreContext>>();
        var dbContext = dbContextFactory.CreateDbContext();

        var region = dbContext.Regions.ToList();
    }
}
