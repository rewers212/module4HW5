using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW5
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(t => t.Location).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);

            builder.HasData(
               new Office
               {
                   OfficeId = 1,
                   Title = "USAOffice",
                   Location = "USA"
               },
               new Office
               {
                   OfficeId = 2,
                   Title = "RussiaOffice",
                   Location = "Russia"
               });
        }
    }
}
