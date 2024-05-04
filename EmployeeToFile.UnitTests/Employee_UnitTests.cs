namespace EmployeeToFile.UnitTests;

public class Employee_UnitTests
{
    [Test]
    public void Serialize_Ok()
    {
        var emp = new Employee()
        {
            _id = 1,
            _BirthDate = new DateTime(1990, 5, 12),
            _City = "Zagreb",
            _Country = "HR",
            _Email = "zagrebEmployee@email.com",
            _FirstName = "testName",
            _IsWork = true,
            _LastName = "testLastName",
            _Phone = "+3859888994653",
            _Position = "pos1",
            _PostalCode = "12345",
            _SecondName = "testSecondName"
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
            _BirthDate = new DateTime(1700, 5, 12)
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
        var emp1 = Employee.Deserialize (dataString);

        var empExpected = new Employee()
        {
            _id = 1,
            _BirthDate = new DateTime(1990, 5, 12),
            _City = "Zagreb",
            _Country = "HR",
            _Email = "zagrebEmployee@email.com",
            _FirstName = "testName",
            _IsWork = true,
            _LastName = "testLastName",
            _Phone = "+3859888994653",
            _Position = "pos1",
            _PostalCode = "12345",
            _SecondName = "testSecondName"
        };

        Assert.That(emp1._id, Is.EqualTo(empExpected._id));
        Assert.That(emp1._FirstName, Is.EqualTo(empExpected._FirstName));
        Assert.That(emp1._SecondName, Is.EqualTo(empExpected._SecondName));
        Assert.That(emp1._LastName, Is.EqualTo(empExpected._LastName));
        Assert.That(emp1._Position, Is.EqualTo(empExpected._Position));
        Assert.That(emp1._Country, Is.EqualTo(empExpected._Country));
        Assert.That(emp1._City, Is.EqualTo(empExpected._City));
        Assert.That(emp1._Email, Is.EqualTo(empExpected._Email));
        Assert.That(emp1._Phone, Is.EqualTo(empExpected._Phone));
        Assert.That(emp1._PostalCode, Is.EqualTo(empExpected._PostalCode));
        Assert.That(emp1._BirthDate, Is.EqualTo(empExpected._BirthDate));
        Assert.That(emp1._IsWork, Is.EqualTo(empExpected._IsWork));
    }

    [Test]
    public void Deserialize_ThrowsException()
    {
        string dataString = "1;123;testSecondName;testLastName;pos1;"
                 + "HR;Zagreb;zagrebEmployee@email.com;+3859888994653;12345;05/12/1990;True";
        var emp1 = Employee.Deserialize(dataString);
    }
}
