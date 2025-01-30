using System.Collections;
using System.Collections.Generic;

namespace MyData;

public class Country : ReferenceEntity
{
    public CountryId Id { get; set; }
    public CountryInfo? Info { get; set; }
    //public Currency? Currency { get; set; }
    public RegionId? RegionId { get; set; }
    public Region? Region { get; set; }
    public SubregionId? SubregionId { get; set; }
    public Subregion? Subregion { get; set; }
    public ICollection<State> States { get; set; } = new List<State>();
    public override EntityKind Kind => EntityKind.Country;
    public override EntityDomain Domain => EntityDomain.Core;
}
