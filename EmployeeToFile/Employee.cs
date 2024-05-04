using System.Globalization;

namespace EmployeeToFile
{
    public class Employee
    {
        //TODO: Remove _ and make _id => Id
        public int Id;

        public string FirstName;
        public string SecondName;
        public string LastName;
        public string Position;
        public string Country;
        public string City;
        public string Email;
        public string Phone;
        public string PostalCode;
        public DateTime BirthDate;
        public bool IsWork;

        public string Serialize()
        {
            if (BirthDate < new DateTime(1900, 1, 1))
            {
                throw new ArgumentException("Invalid BirthDate");
            }

            return Id.ToString() + ";" + FirstName + ";" + SecondName + ";" + LastName + ";" + Position
                + ";" + Country + ";" + City + ";" + Email + ";" + Phone + ";"
                + PostalCode + ";" + BirthDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) + ";"
                + IsWork;
        }

        //TODO: Write 2 Unit Tests: 1 Ok , 1 Fail
        public static Employee Deserialize(string str)
        {
            string[] data = str.Split(';');
            var emp = new Employee();

            emp.Id = Convert.ToInt32(data[0]);
            emp.FirstName = data[1];
            if (emp.FirstName == null)
            {
                throw new ArgumentException("Invalid FirstName");
            }
            foreach (var item in emp.FirstName)
            {
                if(!char.IsLetter(item))
                {
                    throw new ArgumentException("Invalid FirstName");
                }
              
            }
            emp.SecondName = data[2];
            emp.LastName = data[3];
            emp.Position = data[4];
            emp.Country = data[5];
            emp.City = data[6];
            emp.Email = data[7];
            emp.Phone = data[8];
            emp.PostalCode = data[9];
            emp.BirthDate = Convert.ToDateTime(data[10]);
            emp.IsWork = Convert.ToBoolean(data[11]);

            return emp;
        }
    }
}
