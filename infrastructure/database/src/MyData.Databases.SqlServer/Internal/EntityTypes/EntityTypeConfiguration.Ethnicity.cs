using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Databases.Internal;

internal class EthnicityEntityTypeConfiguration : IEntityTypeConfiguration<Ethnicity>
{
    public void Configure(EntityTypeBuilder<Ethnicity> builder)
    {
        
    }
}
