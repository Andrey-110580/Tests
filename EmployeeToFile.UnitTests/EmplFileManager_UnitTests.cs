using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToFile.UnitTests
{
    public class EmplFileManager_UnitTests
    {
        [Test]
        public void Export_OK()
        {
            List<Employee> emplList = new List<Employee>();

            var emp = new Employee()
            {
                Id = 1,
                BirthDate = new DateTime(1990, 5, 12),
                City = "Zagreb",
                Country = "HR",
                Email = "zagrebEmployee@email.com",
                FirstName = "testName",
                IsWork = true,
                LastName = "testLastName",
                Phone = "+3859888994653",
                Position = "pos1",
                PostalCode = "12345",
                SecondName = "testSecondName"
            };
            var emp2 = new Employee()
            {
                Id = 2,
                BirthDate = new DateTime(1992, 2, 12),
                City = "Zagreb",
                Country = "HR",
                Email = "zagrebEmployee2@email.com",
                FirstName = "testName2",
                IsWork = true,
                LastName = "testLastName2",
                Phone = "+3859888992",
                Position = "pos2",
                PostalCode = "123452",
                SecondName = "testSecondName2"
            };
            emplList.Add(emp);
            emplList.Add(emp2);

            var empListFile = Employee.
        }
    }
}
