using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW5
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.Property(t => t.EmployeeId).IsRequired();
            builder.Property(t => t.Rate).IsRequired();
            builder.Property(t => t.StartedDate).IsRequired().HasMaxLength(7);
            builder.Property(t => t.ProjectId).IsRequired();

            builder.HasData(
                new EmployeeProject
                {
                    EmployeeProjectId = 1,
                    Rate = 1000m,
                    StartedDate = new DateTime(1999, 11, 11),
                    EmployeeId = 1,
                    ProjectId = 1
                },
                new EmployeeProject
                {
                    EmployeeProjectId = 2,
                    Rate = 2000m,
                    StartedDate = new DateTime(1777, 7, 1),
                    EmployeeId = 2,
                    ProjectId = 2
                });
        }
    }
}
