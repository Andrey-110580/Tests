namespace EmployeeToFile.UnitTests;

public class Employee_UnitTests
{
    //[SetUp]
    //public void Setup()
    //{
    //}

    [Test]
    public void Test1()
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

    //[Test]
    //public void Test2()
    //{
    //    Assert.Pass();
    //}
}
