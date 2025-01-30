using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Quartz;

public static class JobExecutionContextExtensions
{
    public static IJobExecutionContext PutFailure(this IJobExecutionContext context)
    {
        return context;

    }


    public static bool HasJobFailure(this IJobExecutionContext context, string key)
    {
        return true;
    }
}
