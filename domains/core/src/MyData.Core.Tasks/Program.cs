﻿using Quartz;
using Microsoft.Extensions.Hosting;
using MyData.Core.Tasks;
using MyData.Clients;
using MyData.Configuration;
using MyData.Databases;

var builder = Host.CreateApplicationBuilder();

builder.AddMyConfigs();
builder.AddMyClients(options =>
{
    options.UseRESTCountryClient();
});
builder.AddMyDatabases(options =>
{
    options.UseSqlServer();
});
builder.AddQuartzJobs();

await builder.Build().RunAsync();