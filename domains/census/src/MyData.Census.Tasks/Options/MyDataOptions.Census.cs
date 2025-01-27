using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Census.Tasks.Options;

internal class MyDataCensusOptions
{
    public string ApiKey { get; set; }
    public IEnumerable<string> Years { get; set; }
    public Uri Endpoint { get; set; }
}
