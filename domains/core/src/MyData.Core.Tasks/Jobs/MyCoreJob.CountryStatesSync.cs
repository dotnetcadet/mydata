using Quartz;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyData.Core.Tasks.Jobs;

using MyData.Clients;
using MyData.Clients.RESTCountry;
using MyData.Databases;

internal class MyCoreCountryStatesSyncJob : IJob
{
    private readonly IClientFactory clientFactory;
    private readonly IDbContextFactory<CoreContext> dbContextFactory;

    public MyCoreCountryStatesSyncJob(
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

        }
        catch (Exception exception)
        {

        }
    }
}
