using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW5
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Title
                {
                    TitleId = 1,
                    Name = "Developer"
                },
                new Title
                {
                    TitleId = 2,
                    Name = "QA"
                });
        }
    }
}
