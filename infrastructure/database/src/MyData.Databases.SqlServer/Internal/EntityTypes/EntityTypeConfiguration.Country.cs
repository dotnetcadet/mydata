using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyData.Databases.Internal;

internal class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Countries", "core");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id);
        builder.OwnsOne(p => p.Currency, complex =>
        {
            complex.Property(p => p.Code).HasColumnName("Currency");
            complex.Property(p => p.Name).HasColumnName("CurrencyName");
            complex.Property(p => p.Symbol).HasColumnName("CurrencySymbol");
        });
        builder.OwnsOne(p => p.Info, complex =>
        {
            complex.Property(p => p.Name).HasColumnName("Name");
            complex.Property(p => p.Code).HasColumnName("Code");
            complex.Property(p => p.ISO2).HasColumnName("ISO2");
            complex.Property(p => p.ISO3).HasColumnName("ISO3");
            complex.Property(p => p.Capital).HasColumnName("Capital");
            complex.Property(p => p.PhoneCore).HasColumnName("PhoneCore");
        });

        builder.HasOne(p => p.Subregion)
            .WithMany(p => p.Countries)
            .HasForeignKey(p => p.SubregionId);

        builder.HasOne(p => p.Region)
            .WithMany(p => p.Countries)
            .HasForeignKey(p => p.RegionId);

        builder.HasMany(p => p.States)
            .WithOne(p => p.Country)
            .HasForeignKey(p => p.CountryId);
    }
}