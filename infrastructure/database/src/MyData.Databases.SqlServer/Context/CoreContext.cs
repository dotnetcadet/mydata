using System;
using Microsoft.EntityFrameworkCore;

namespace MyData.Databases;

using Internal;

public class CoreContext : DbContext
{
    public CoreContext(DbContextOptions<CoreContext> options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Subregion> Subregions { get; set; }
    public DbSet<State> States { get; set; }

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
        builder.ApplyConfiguration(new RegionEntityTypeConfiguration());
        builder.ApplyConfiguration(new SubregionEntityTypeConfiguration());
        builder.ApplyConfiguration(new CountryEntityTypeConfiguration());
        builder.ApplyConfiguration(new StateEntityTypeConfiguration());
    }
}