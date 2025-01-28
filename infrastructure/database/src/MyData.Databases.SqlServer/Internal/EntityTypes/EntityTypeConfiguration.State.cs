using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyData.Databases.Internal;

internal class StateEntityTypeConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("States", "core");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("id");
        builder.OwnsOne(p => p.Info, complex =>
        {
            complex.Property(p => p.Name).HasColumnName("Name");
        });

        builder.HasOne(p => p.Country)
            .WithMany(p => p.States)
            .HasForeignKey(p => p.CountryId);
    }
}
