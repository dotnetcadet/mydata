
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Core.Tasks.Jobs;

using MyData.Clients;
using MyData.Clients.RESTCountry;

internal class MyCountrySyncCoreJob : IJob
{
    private readonly IClientFactory clientFactory;

    public MyCountrySyncCoreJob(
        IClientFactory clientFactory)
    {
        this.clientFactory = clientFactory;
    }
    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            // Create Client
            using var client = clientFactory.Create<IRESTCountryClient>();

            // Get all country data
            var response = await client.GetAllCountriesAsync(context.CancellationToken);

            // Process Response
            if (response.If(out ClientError error, out ClientSuccessCollection<RESTCountry> collection))
            {

            }
            else
            {

            }
        }
        catch (Exception exception)
        {

        }
    }
}
