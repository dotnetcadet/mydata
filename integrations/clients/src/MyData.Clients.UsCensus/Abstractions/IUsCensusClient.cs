using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.UsCensus;

public interface IUsCensusClient : IClient
{

    // route + /dec
    IUsDecennialCensusRequestBuilder UseDecennialCensus(UsCensusYear year);
}
