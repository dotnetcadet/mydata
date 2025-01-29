
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Core.Tasks.Jobs;

using Microsoft.EntityFrameworkCore;
using MyData.Clients;
using MyData.Clients.RESTCountry;
using MyData.Databases.SqlServer;
using System.Buffers.Binary;

internal class MyCountrySyncCoreJob : IJob
{
    private readonly IClientFactory clientFactory;
    private readonly IDbContextFactory<CoreContext> dbContextFactory;

    public MyCountrySyncCoreJob(
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
            using var client = clientFactory.Create<IRESTCountryClient>();

            // Get all country data
            var response = await client.GetAllCountriesAsync(context.CancellationToken);

            // Process Response
            if (response.If(out ClientError error, out ClientSuccessCollection<RESTCountry> success))
            {
                // TODO: Handle error
            }
            else
            {
                var countries = success.Data;

                var regions = countries
                    .Where(p => !string.IsNullOrEmpty(p.Region))
                    .Select(p => p.Region!.Trim())
                    .Distinct(StringComparer.OrdinalIgnoreCase);

                var existing = dbContext.Regions.ToArray();

                foreach (var region in regions)
                {
                    var isExisting = existing.Any(p => p.Info!.Name!.Equals(region, StringComparison.OrdinalIgnoreCase));
                    if (!isExisting)
                    {
                        dbContext.Regions.Add(new Region()
                        {
                            Info = new RegionInfo()
                            {
                                Name = region
                            },
                            Reference = new Reference()
                            {
                                Link = client.Endpoint,
                                Source = success.GetRESTCountrySource(),
                                Type = ReferenceType.WebApi
                            }
                        });
                    }
                }

                var changes = await dbContext.SaveChangesAsync(context.CancellationToken);


                //dbContext.Bulk

                //foreach (var region in countries.GroupBy(p => p.Region, StringComparer.OrdinalIgnoreCase).ToDictionary())
                //{
                //    foreach (var country in region)
                //    {

                //    }
                //}

                //var regions = countries
                //    .Select(p => p.Region)
                //    .Distinct(StringComparer.OrdinalIgnoreCase)
                //    .Select(region =>
                //    {
                //        return new Region()
                //        {

                //            Info = new RegionInfo()
                //            {
                //                Name = region
                //            },
                //            Reference = new Reference()
                //            {
                //                Source = success.GetRESTCountrySource(),
                //                Link = client.Endpoint,
                //                Type = ReferenceType.WebApi
                //            }
                //        };
                //    });


                //var subregions = countries.Select(p => p.Subregion).Distinct(StringComparer.OrdinalIgnoreCase);
            }
        }
        catch (Exception exception)
        {

        }
    }
}
