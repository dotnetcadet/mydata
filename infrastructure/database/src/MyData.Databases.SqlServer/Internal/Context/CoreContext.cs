using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyData.Databases.Internal;

internal class CoreContext : DbContext
{
    public CoreContext()
    {
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<CountryId>().HaveConversion<CountryIdConverter>();
        builder.Properties<CountryId?>().HaveConversion<NullCountryIdConverter>();
        builder.Properties<RegionId>().HaveConversion<RegionIdConverter>();
        builder.Properties<RegionId?>().HaveConversion<NullRegionIdConverter>();
        builder.Properties<StateId>().HaveConversion<StateIdConverter>();
        builder.Properties<StateId?>().HaveConversion<NullStateIdConverter>();
        builder.Properties<SubregionId>().HaveConversion<SubregionIdConverter>();
        builder.Properties<SubregionId?>().HaveConversion<NullSubregionIdConverter>();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CountryEntityTypeConfiguration());
       // builder.ApplyConfiguration(new EthnicityEntityTypeConfiguration());
        builder.ApplyConfiguration(new RegionEntityTypeConfiguration());
        builder.ApplyConfiguration(new StateEntityTypeConfiguration());
        builder.ApplyConfiguration(new SubregionEntityTypeConfiguration());
    }
}