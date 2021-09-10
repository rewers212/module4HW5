using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module4HW5
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.HiredDate).IsRequired().HasMaxLength(7);
            builder.Property(t => t.OfficeId).IsRequired();
            builder.Property(t => t.TitleId).IsRequired();

            builder.HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Tom",
                    LastName = "Soyer",
                    HiredDate = new DateTime(1985, 11, 21),
                    DateOfBirth = new DateTime(1961, 8, 4),
                    TitleId = 1,
                    OfficeId = 1
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Avram",
                    LastName = "Linkoln",
                    HiredDate = new DateTime(2015, 8, 1, 11, 22, 1),
                    DateOfBirth = new DateTime(1993, 2, 11),
                    TitleId = 2,
                    OfficeId = 2
                });
        }
    }
}
