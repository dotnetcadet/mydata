using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyData.Databases.Internal;

internal class StateIdConverter : ValueConverter<StateId, int>
{
    public StateIdConverter() : base(p => p.Value, p => new(p)) { }
}
internal class NullStateIdConverter : ValueConverter<StateId?, int?>
{
    public NullStateIdConverter() : base(
        p => p.HasValue ? p.Value.Value : default,
        p => p.HasValue ? new(p.Value) : default)
    {
    }
}