using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyData.Databases.Internal;

internal class StateEntityTypeConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("CountriesStates", "core");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).UseIdentityColumn(1, 1).HasColumnName("Id");
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

        builder.HasOne(p => p.Country)
            .WithMany(p => p.States)
            .HasForeignKey(p => p.CountryId);
    }
}
