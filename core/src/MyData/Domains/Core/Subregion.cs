using System.Collections.Generic;

namespace MyData;

public class Subregion
{
    public SubregionId Id { get; set; }
    public SubregionInfo? Info { get; set; }
    public RegionId RegionId { get; set; }
    public Region? Region { get; set; }
    public ICollection<Country> Countries { get; set; } = new List<Country>();
}
