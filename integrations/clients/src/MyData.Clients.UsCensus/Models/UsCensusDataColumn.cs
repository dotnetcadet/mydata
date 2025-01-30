using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Clients.UsCensus;

[DebuggerDisplay("{Name}: Index={Index}")]
public sealed class UsCensusDataColumn
{
    public int Index { get; init; }
    public string Name { get; internal set; }
}
