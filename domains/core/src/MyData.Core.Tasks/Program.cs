using Quartz;
using Microsoft.Extensions.Hosting;
using MyData.Core.Tasks;
using MyData.Clients;
using MyData.Configuration;
using MyData.Databases;
using MyData.Quartz;

var builder = Host.CreateApplicationBuilder();

builder.AddMyConfigs();
builder.AddMyQuartzJobs("Core");
builder.AddMyClients(options =>
{
    options.UseRESTCountryClient();
});
builder.AddMyDatabases(options =>
{
    options.UseSqlServer();
});

await builder.Build().RunAsync();