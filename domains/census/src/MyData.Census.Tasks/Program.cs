using Quartz;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MyData.Census.Tasks.Options;
using MyData.Census.Tasks;
using MyData.Clients;

var builder = Host.CreateApplicationBuilder();


builder.Configuration.AddUserSecrets("7df480d7-c91f-4b77-9780-a191200e0ebc");
builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddOptions<MyDataOptions>()
    .Configure<IConfiguration>((options, configuration) =>
        configuration.GetSection("MyData").Bind(options));

builder.Services.AddHttpClient();

builder.AddClients(options =>
{
    options.AddRESTCountriesClient();
});

builder.AddMyDataDbContext();
builder.AddMyDataQuartzJobs();



var app = builder.Build();

await app.RunAsync();