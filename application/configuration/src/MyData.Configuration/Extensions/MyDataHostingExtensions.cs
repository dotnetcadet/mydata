using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Configuration;

public static class MyDataHostingExtensions
{
    public static IHostApplicationBuilder AddMyConfigs(this IHostApplicationBuilder builder)
    {
        builder.Configuration.AddJsonFile("appsettings.json");

        if (builder.Environment.IsDevelopment() && Path.Exists(Path.GetFullPath("appsettings.Development.json")))
        {
            builder.Configuration.AddJsonFile("appsettings.Development.json");
        }

        return builder;
    }
}
