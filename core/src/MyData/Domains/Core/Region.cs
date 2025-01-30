using System.Collections.Generic;

namespace MyData;

public class Region : ReferenceEntity
{
    public RegionId Id { get; set; }
    public RegionInfo? Info { get; set; }
    public ICollection<Country> Countries { get; set; } = new List<Country>();
    public ICollection<Subregion> Subregions { get; set; } = new List<Subregion>();
    public override EntityKind Kind => EntityKind.Region;
    public override EntityDomain Domain => EntityDomain.Core;
}
