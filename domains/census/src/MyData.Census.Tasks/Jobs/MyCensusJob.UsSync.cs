using Quartz;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyData.Census.Tasks.Jobs;

using MyData.Clients;
using MyData.Clients.UsCensus;
using MyData.Databases;

internal partial class MyUsCensusSyncJob : IJob
{
    //private readonly ILogger logger;
    private readonly IClientFactory clientFactory;
    private readonly IDbContextFactory<CoreContext> dbContextFactory;

    public MyUsCensusSyncJob(
        IClientFactory clientFactory,
        IDbContextFactory<CoreContext> dbContextFactory)
    {
        this.clientFactory = clientFactory;
        this.dbContextFactory = dbContextFactory;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            // Create database connection
            using var dbContext = await dbContextFactory.CreateDbContextAsync(context.CancellationToken);

            // Create Client
            using var client = clientFactory.Create<IUsCensusClient>();

            foreach (var year in Enum.GetValues<UsCensusYear>())
            {
                var byRaceRequest = await client.UseDecennialCensus(year).WithDemographicProfile()
                    .IncludeRacialCountByAffricanAmerican()
                    .GetByCountryAsync();

            }

            // Get all country data
            var response = await client.GetAllCountriesAsync(context.CancellationToken);

            // Process Response
            if (response.If(out ClientError error, out ClientSuccessCollection<RESTCountry> success))
            {
                // TODO: Handle error
            }
            else
            {
                //if (!(await TryUpcertAsync(dbContext, client, success, context.CancellationToken)))
                //{

                //}
            }
        }
        catch (Exception exception)
        {

        }
    }
}
