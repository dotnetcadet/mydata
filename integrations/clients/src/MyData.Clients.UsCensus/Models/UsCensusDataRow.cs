using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyData.Clients.UsCensus;

[DebuggerDisplay("Values: {values.Count}")]
public sealed class UsCensusDataRow
{
    private readonly List<string?> values;

    public UsCensusDataRow()
    {
        values = new List<string?>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="columnIndex"><see cref="UsCensusDataColumn.Index"/></param>
    /// <returns></returns>
    public string? this[int columnIndex] => values[columnIndex];

    internal void AddValue(string? value) => values.Add(value);
}