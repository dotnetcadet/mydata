using Quartz;
using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyData.Quartz;

public static class QuartzSchedulesExtensions
{
    public static HostApplicationBuilder AddMyQuartzJobs(this HostApplicationBuilder builder, string domain)
    {
        builder.Services.AddQuartz(options =>
        {
            var configuration = builder.Configuration;
            var schedules = configuration.GetSection($"MyData:Domains:{domain}:Tasks").GetChildren();

            var jobs = Assembly.GetEntryAssembly().GetTypes()
                .Where(type => type.IsAssignableTo(typeof(IJob)));

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
                        configure.StartNow();
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
