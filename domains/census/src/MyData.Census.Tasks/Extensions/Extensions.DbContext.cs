using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyData.Census.Tasks.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Census.Tasks;

internal static class DbContextExtensions
{
    public static HostApplicationBuilder AddMyDataDbContext(this HostApplicationBuilder builder)
    {
        builder.Services.AddPooledDbContextFactory<MyDataContext>(options =>
        {
            options.UseNpgsql("Server=127.0.0.1;Port=5432;Database=mydata;User Id=admin;Password=Kg<j>aie48934!245jf;");
        });

        return builder;
    }
}
