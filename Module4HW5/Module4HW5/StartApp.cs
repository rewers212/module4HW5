using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Module4HW5
{
    public class StartApp
    {
        private ContextFactory optionBuilder = new ContextFactory();

        public void FirstQuery()
        {
            using (var dbContext = optionBuilder.CreateDbContext(new string[0]))
            {
                var result = dbContext.Employees.Select(t => new { Name = t.FirstName + " " + t.LastName, Title = t.Title.Name, Location = t.Office.Location }).ToArray();
            }
        }
        public void SecondQuery()
        {
            using (var dbContext = optionBuilder.CreateDbContext(new string[0]))
            {
                    var result2 = dbContext.Employees.Select(t => new { Name = t.FirstName + " " + t.LastName, Experience = (DateTime.Now - t.HiredDate).TotalDays / 365 }).ToArray();
                }
        }

        public void ThirdQuery()
        {
            using (var dbContext = optionBuilder.CreateDbContext(new string[0]))
            {
                var emp = dbContext.Employees.Find(1);
                emp.OfficeId = 3;
                dbContext.Update(emp);

                var office = dbContext.Offices.Find(1);
                office.Location = "New York";
                dbContext.Update(office);

                dbContext.SaveChanges();
            }
        }

        public void FourthQuery()
        {
            using (var dbContext = optionBuilder.CreateDbContext(new string[0]))
            {
                dbContext.Employees.Add(
                    new Employee
                    {
                        FirstName = "Ivan ",
                        LastName = "Kardan",
                        HiredDate = new DateTime(2017, 1, 20, 0, 0, 0),
                        DateOfBirth = new DateTime(1946, 6, 14),
                        Title = new Title
                        {
                            Name = "Poc"
                        },
                        OfficeId = 1
                    });

                dbContext.SaveChanges();

                var newEmployeeProject = new EmployeeProject
                {
                    Rate = 50000m,
                    StartedDate = new DateTime(2001, 11, 11, 2, 2, 2),
                    EmployeeId = 4,
                    ProjectId = 3
                };

                dbContext.EmployeeProject.Add(newEmployeeProject);

                dbContext.SaveChanges();
            }
        }

        public void FifthQuery()
        {
            using (var dbContext = optionBuilder.CreateDbContext(new string[0]))
            {
                dbContext.Employees.Remove(dbContext.Employees.FirstOrDefault(t => t.Title.Name == "Poc"));
                dbContext.SaveChanges();
            }
        }

        public void SixthQuery()
        {
            using (var dbContext = optionBuilder.CreateDbContext(new string[0]))
            {
                var result3 = dbContext.Employees
                   .Select(t => new { Name = t.FirstName + " " + t.LastName, Title = t.Title.Name })
                   .ToList()
                   .GroupBy(t => t.Title)
                   .Where(t => !t.Key.Contains("a", StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}

