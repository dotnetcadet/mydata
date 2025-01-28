using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyData.Databases.Internal;

internal class CountryIdConverter : ValueConverter<CountryId, int>
{
    public CountryIdConverter() : base(p => p.Value, p => new (p))
    {
    }
}

internal class NullCountryIdConverter : ValueConverter<CountryId?, int?>
{
    public NullCountryIdConverter() : base(
        p => p.HasValue ? p.Value.Value : default, 
        p => p.HasValue ? new (p.Value) : default)
    {
    }
}
