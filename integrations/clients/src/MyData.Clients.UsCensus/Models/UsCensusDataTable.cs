using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MyData.Clients.UsCensus;

using MyData.Clients.UsCensus.Internal;

[JsonConverter(typeof(CensusDataTableConverter))]
public class UsCensusDataTable
{
    private readonly List<UsCensusDataColumn> columns;
    private readonly List<UsCensusDataRow> rows;
    
    public UsCensusDataTable()
    {
        columns = new List<UsCensusDataColumn>();
        rows = new List<UsCensusDataRow>();
    }

    /// <summary>
    /// 
    /// </summary>
    public IReadOnlyList<UsCensusDataColumn> Columns => columns.AsReadOnly();

    /// <summary>
    /// 
    /// </summary>
    public IReadOnlyList<UsCensusDataRow> Rows => rows.AsReadOnly();

    internal void AddRow(UsCensusDataRow row) => rows.Add(row);

    internal void AddColumn(UsCensusDataColumn column) => columns.Add(column);
}
