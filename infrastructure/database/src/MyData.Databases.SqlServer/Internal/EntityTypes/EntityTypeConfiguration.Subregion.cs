using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyData.Databases.Internal;

internal class SubregionEntityTypeConfiguration : IEntityTypeConfiguration<Subregion>
{
    public void Configure(EntityTypeBuilder<Subregion> builder)
    {
        builder.ToTable("CountriesSubregions", "core");
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

        builder.HasOne(p => p.Region)
            .WithMany(p => p.Subregions)
            .HasForeignKey(p => p.RegionId);

        builder.HasMany(p => p.Countries)
            .WithOne(p => p.Subregion)
            .HasForeignKey(p => p.SubregionId);
    }
}
