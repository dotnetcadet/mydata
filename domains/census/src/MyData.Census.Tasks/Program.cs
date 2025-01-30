using Microsoft.Extensions.Hosting;
using MyData.Clients;
using MyData.Clients.UsCensus;
using MyData.Configuration;
using MyData.Databases;
using MyData.Quartz;

var builder = Host.CreateApplicationBuilder();

builder.AddMyConfigs();
builder.AddMyQuartzJobs("Core");
builder.AddMyClients(options =>
{
    options.UseCensusClient();
});
builder.AddMyDatabases(options =>
{
    options.UseSqlServer();
});

await builder.Build().RunAsync();