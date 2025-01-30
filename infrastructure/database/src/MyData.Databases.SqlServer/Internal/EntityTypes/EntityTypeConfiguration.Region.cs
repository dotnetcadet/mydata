using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyData.Databases.Internal;

internal class RegionEntityTypeConfiguration : IEntityTypeConfiguration<Region>
{
    public void Configure(EntityTypeBuilder<Region> builder)
    {
        builder.ToTable("CountriesRegions", "core");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).UseIdentityColumn(1, 1);
        builder.OwnsOne(p => p.Info, complex =>
        {
            complex.Property(p => p.Name).HasColumnName("Name");
        });
        builder.OwnsOne(p => p.Reference, complex =>
        {
            complex.Property(p => p.Source).HasColumnName("ReferenceSource");
            complex.Property(p => p.Link).HasColumnName("ReferenceLink");
            complex.Property(p => p.Type).HasColumnName("ReferenceType");
        });
        builder.Ignore(p => p.Kind);
        builder.Ignore(p => p.Domain);

        builder.HasMany(p => p.Subregions)
            .WithOne(p => p.Region)
            .HasForeignKey(p => p.RegionId);

        builder.HasMany(p => p.Countries)
            .WithOne(p => p.Region)
            .HasForeignKey(p => p.RegionId);
    }
}
