using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Databases.Internal;

internal class SubregionEntityTypeConfiguration : IEntityTypeConfiguration<Subregion>
{
    public void Configure(EntityTypeBuilder<Subregion> builder)
    {
        
    }
}
