using Quartz;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace MyData.Core.Tasks.Jobs;

using MyData.Quartz;
using MyData.Clients;
using MyData.Clients.RESTCountry;
using MyData.Databases;

internal class MyCoreCountrySyncJob : IJob
{
    //private readonly ILogger logger;
    private readonly IClientFactory clientFactory;
    private readonly IDbContextFactory<CoreContext> dbContextFactory;

    public MyCoreCountrySyncJob(
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
                if (!(await TryUpcertAsync(dbContext, client, success, context.CancellationToken))) 
                {
                    
                }
            }
        }
        catch (Exception exception)
        {

        }
    }

    private async Task<bool> TryUpcertAsync(
        CoreContext dbContext, 
        IRESTCountryClient client,
        ClientSuccessCollection<RESTCountry> response,
        CancellationToken cancellationToken)
    {
        try
        {
            int changes = 0;

            foreach (var region in response.Data.GroupBy(p => p.Region, StringComparer.OrdinalIgnoreCase))
            {
                var hasRegion = await dbContext.Regions
                    .Include(p => p.Subregions)
                    .Include(p => p.Countries)
                    .FirstOrDefaultAsync(p => p.Info!.Name == region.Key);

                if (region.Key is not null && hasRegion is null)
                {
                    hasRegion = dbContext.Regions.Add(new Region()
                    {
                        Info = new RegionInfo()
                        {
                            Name = region.Key
                        },
                        Reference = new Reference()
                        {
                            Link = client.Endpoint,
                            Source = response.GetRESTCountrySource(),
                            Type = ReferenceType.WebApi
                        }
                    }).Entity;

                    changes =+ await dbContext.SaveChangesAsync(cancellationToken);
                }

                foreach (var subregion in region.GroupBy(p => p.Subregion, StringComparer.OrdinalIgnoreCase))
                {
                    var hasSubregion = hasRegion
                        ?.Subregions
                        ?.FirstOrDefault(p => StringComparer.OrdinalIgnoreCase.Equals(p.Info?.Name, region.Key));

                    if (region.Key is not null && subregion.Key is not null && hasSubregion is null)
                    {
                        hasSubregion = dbContext.Subregions.Add(new Subregion()
                        {
                            Info = new SubregionInfo()
                            {
                                Name = subregion.Key
                            },
                            RegionId = hasRegion!.Id,
                            Reference = new Reference()
                            {
                                Link = client.Endpoint,
                                Source = response.GetRESTCountrySource(),
                                Type = ReferenceType.WebApi
                            }
                        }).Entity;

                        changes =+ await dbContext.SaveChangesAsync(cancellationToken);
                    }
                    
                    foreach (var country in subregion)
                    {
                        var hasCountry = hasRegion
                            ?.Countries
                            ?.FirstOrDefault(p => StringComparer.OrdinalIgnoreCase.Equals(p.Info?.Name, country.Name?.Official));

                        if (hasCountry is null)
                        {
                            dbContext.Countries.Add(new Country()
                            {
                                Info = new CountryInfo()
                                {
                                    Name = country!.Name!.Official,
                                    ISO2 = country.Cca2,
                                    ISO3 = country.Cca3,
                                    Code = country.Ccn3,
                                    Capital = string.Join(';', country?.Capital ?? [])
                                },
                                Reference = new Reference()
                                {
                                    Link = client.Endpoint,
                                    Source = response.GetRESTCountrySource(),
                                    Type = ReferenceType.WebApi
                                },
                                RegionId = hasRegion?.Id,
                                SubregionId = hasSubregion?.Id
                            });
                        }
                        else
                        {
                            hasCountry!.Info!.Name = country!.Name!.Official;
                            hasCountry!.Info!.ISO2 = country.Cca2;
                            hasCountry!.Info!.ISO3 = country.Cca3;
                            hasCountry!.Info!.Code = country.Ccn3;
                            hasCountry!.Info!.Capital = string.Join(';', country?.Capital ?? []);
                            hasCountry!.RegionId = hasRegion?.Id;
                            hasCountry!.SubregionId = hasSubregion?.Id;
                        }
                    }

                    changes =+ await dbContext.SaveChangesAsync(cancellationToken);
                }
            }

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
