using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.UsCensus.Internal;

internal class UsCensusRequest : ClientRequest
{
    public UsCensusRequest(Uri endpoint) : base(endpoint)
    {

    }
}
