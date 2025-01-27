using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyData.Census.Tasks.Context;
using MyData.Census.Tasks.Options;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace MyData.Census.Tasks.Jobs;

internal partial class MyDataCensusJob : IJob
{
    private readonly MyDataOptions options;
    private readonly IHttpClientFactory httpClientFactory;
    private readonly IDbContextFactory<MyDataContext> dbContextFactory;

    public MyDataCensusJob(
        IOptions<MyDataOptions> options,
        IHttpClientFactory httpClientFactory,
        IDbContextFactory<MyDataContext> dbContextFactory)
    {
        this.options = options.Value;
        this.httpClientFactory = httpClientFactory;
        this.dbContextFactory = dbContextFactory;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine("Hello");
        var httpClient = httpClientFactory.CreateClient(nameof(MyDataCensusJob));
        var dbContext = await dbContextFactory.CreateDbContextAsync();

        // foreach (var year in options.Census.Years)
        // {
        //     var builder = new UriBuilder(options.Census.Endpoint);

        //     builder.Path = string.Join("/",
        //         builder.Path,
        //         year,
        //         "pep/charagegroups");

        //     builder.Query = string.Join('&',
        //         "get=NAME,POP",
        //         "for=state:*");

        //     var request = new HttpRequestMessage()
        //     {
        //         RequestUri = builder.Uri,
        //         Method = HttpMethod.Get
        //     };

        //     var response = await httpClient.SendAsync(request);

        //     if (!response.IsSuccessStatusCode)
        //     {
        //         // TODO: Something Happened
        //     }

        //     using var stream = response.Content.ReadAsStream();

        //     var json = await JsonObject.ParseAsync(stream);
        //     var array = json.AsArray();
        //     var headers = array[0].AsArray();

        //     int nameIndex = 0;
        //     int popIndex = 0;

        //     for (int i = 0; i < headers.Count; i++)
        //     {
        //         var value = headers[i].ToString();
        //         if (value.Equals("Name"))
        //         {
        //             nameIndex = i;
        //         }
        //         if (value.Equals("POP"))
        //         {
        //             popIndex = i;
        //         }
        //     }


           
        //     foreach (var entry in array.Skip(1))
        //     {
        //         var stat = new CensusByState()
        //         {
        //             State = entry[nameIndex].AsValue().GetValue<string>(),
        //             Population = long.Parse(entry[popIndex].AsValue().GetValue<string>()),
        //             Year = int.Parse(year)
        //         };

        //         dbContext.CensusByStates.Add(stat);
        //     }

        //     var changes = await dbContext.SaveChangesAsync();
        // }





        //    string.Join()


        //    var urinew Uri(, )
        //https://api.census.gov/data/2019/pep/charagegroups?get=NAME,POP&for=state:*




    }
}
