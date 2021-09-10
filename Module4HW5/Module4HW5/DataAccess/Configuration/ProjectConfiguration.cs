using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW5
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
            builder.Property(t => t.Budget).IsRequired();
            builder.Property(t => t.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(t => t.ClientId).IsRequired();
            builder.HasOne(t => t.Client).WithMany(h => h.Projects).HasForeignKey(p => p.ClientId);

            builder.HasData(
                new Project
                {
                    ProjectId = 1,
                    StartedDate = new DateTime(2021, 1, 1),
                    Budget = 1234,
                    Name = "SomeProject1",
                    ClientId = 1
                },
                new Project
                {
                    ProjectId = 2,
                    StartedDate = new DateTime(2020, 4, 1),
                    Budget = 412312,
                    Name = "SomeProject2",
                    ClientId = 2
                },
                new Project
                {
                    ProjectId = 3,
                    StartedDate = new DateTime(2021, 8, 6),
                    Budget = 123124,
                    Name = "SomeProject3",
                    ClientId = 3
                },
                new Project
                {
                    ProjectId = 4,
                    StartedDate = new DateTime(1991, 11, 23),
                    Budget = 122231,
                    Name = "SomeProject4",
                    ClientId = 4
                },
                new Project
                {
                    ProjectId = 5,
                    StartedDate = new DateTime(2001, 11, 15),
                    Budget = 131415,
                    Name = "SomeProject5",
                    ClientId = 5
                });
        }
    }
}
