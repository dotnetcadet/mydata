using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyData.Databases.Internal;

internal class RegionEntityTypeConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("CountriesRegions", "core");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id);
        builder.OwnsOne(p => p.Info, complex =>
        {
            complex.Property(p => p.Name).HasColumnName("Name");
        });


        builder.HasMany(p => p.Subregions)
            .WithOne(p => p.Region)
            .HasForeignKey(p => p.RegionId);

        builder.Ignore(p => p.Countries);

        builder.HasMany(p => p.Countries)
            .WithOne(p => p.Region)
            .HasForeignKey(p => p.RegionId);
    }
}
