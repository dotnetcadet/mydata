using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyData.Databases.Internal;

internal class SubregionIdConverter : ValueConverter<SubregionId, int>
{
    public SubregionIdConverter() : base(p => p.Value, p => new(p)) { }
}
internal class NullSubregionIdConverter : ValueConverter<SubregionId?,int?>
{
    public NullSubregionIdConverter() : base(
        p => p.HasValue ? p.Value.Value : default,
        p => p.HasValue ? new(p.Value) : default)
    {
    }
}