using Quartz;
using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyData.Core.Tasks;

internal static class QuartzSchedulesExtensions
{
    public static HostApplicationBuilder AddQuartzJobs(this HostApplicationBuilder builder)
    {
        builder.Services.AddQuartz(options =>
        {
            var configuration = builder.Configuration;
            var schedules = configuration.GetSection("MyData:Schedules").GetChildren();

            var jobs = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.IsAssignableTo(typeof(IJob)) && type.Name.StartsWith("MyData"));

            foreach (var schedule in schedules)
            {
                // Get Job Settings
                var crontab = schedule.GetValue<string>("Crontab");
                var beginOnStartUp = schedule.GetValue<bool>("BeginOnStartUp");

                // Get Job Identifiers
                var job = jobs.FirstOrDefault(p => p.Name.Equals(schedule.Key, StringComparison.OrdinalIgnoreCase));
                var jobKey = new JobKey(schedule.Key);

                options.AddJob(job, jobKey);
                options.AddTrigger(configure =>
                {
                    configure.WithCronSchedule(crontab);
                    configure.ForJob(jobKey);

                    if (beginOnStartUp)
                    {
                        configure.StartAt(DateTimeOffset.UtcNow.AddSeconds(5));
                    }
                });

                
            }
        });
        builder.Services.AddQuartzHostedService(options =>
        {
            // when shutting down we want jobs to complete gracefully
            options.WaitForJobsToComplete = true;
        });

        return builder;
    }
}
