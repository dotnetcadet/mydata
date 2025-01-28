using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyData.Databases.Internal;

internal class RegionIdConverter : ValueConverter<RegionId, int>
{
    public RegionIdConverter() : base(p => p.Value, p => new(p)) { }
}
internal class NullRegionIdConverter : ValueConverter<RegionId?, int?>
{
    public NullRegionIdConverter() : base(
        p => p.HasValue ? p.Value.Value : default,
        p => p.HasValue ? new(p.Value) : default)
    {
    }
}