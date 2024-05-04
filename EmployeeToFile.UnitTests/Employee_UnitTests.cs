namespace EmployeeToFile.UnitTests;

public class Employee_UnitTests
{
    [Test]
    public void Serialize_Ok()
    {
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

        var result = emp.Serialize();
        var expectedResult = "1;testName;testSecondName;testLastName;pos1;"
                + "HR;Zagreb;zagrebEmployee@email.com;+3859888994653;12345;05/12/1990;True";

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Serialize_ThrowsException()
    {
        var emp = new Employee()
        {
            BirthDate = new DateTime(1700, 5, 12)
        };

        var ex = Assert.Throws<ArgumentException>(() =>
        {
            emp.Serialize();
        });

        Assert.That(ex.Message, Is.EqualTo("Invalid BirthDate"));
    }


    [Test]
    public void Deserialize_Ok()
    {
        string dataString = "1;testName;testSecondName;testLastName;pos1;"
                + "HR;Zagreb;zagrebEmployee@email.com;+3859888994653;12345;05/12/1990;True";
        var emp1 = Employee.Deserialize(dataString);

        var empExpected = new Employee()
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

        Assert.That(emp1.Id, Is.EqualTo(empExpected.Id));
        Assert.That(emp1.FirstName, Is.EqualTo(empExpected.FirstName));
        Assert.That(emp1.SecondName, Is.EqualTo(empExpected.SecondName));
        Assert.That(emp1.LastName, Is.EqualTo(empExpected.LastName));
        Assert.That(emp1.Position, Is.EqualTo(empExpected.Position));
        Assert.That(emp1.Country, Is.EqualTo(empExpected.Country));
        Assert.That(emp1.City, Is.EqualTo(empExpected.City));
        Assert.That(emp1.Email, Is.EqualTo(empExpected.Email));
        Assert.That(emp1.Phone, Is.EqualTo(empExpected.Phone));
        Assert.That(emp1.PostalCode, Is.EqualTo(empExpected.PostalCode));
        Assert.That(emp1.BirthDate, Is.EqualTo(empExpected.BirthDate));
        Assert.That(emp1.IsWork, Is.EqualTo(empExpected.IsWork));
    }

    [Test]
    public void Deserialize_ThrowsException()
    {
        string dataString = "1; 245;testSecondName;testLastName;pos1;"
                 + "HR;Zagreb;zagrebEmployee@email.com;+3859888994653;12345;05/12/1990;True";
        

        var ex = Assert.Throws<ArgumentException>(() =>
        {
            var emp1 = Employee.Deserialize(dataString);
        });

        Assert.That(ex.Message, Is.EqualTo("Invalid FirstName"));


    }
}
