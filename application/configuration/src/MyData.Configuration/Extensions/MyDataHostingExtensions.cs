using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Configuration;

public static class MyDataHostingExtensions
{
    public static IHostApplicationBuilder AddMyDataConfigs(this IHostApplicationBuilder builder)
    {


        return builder;
    }
}
