using System.Globalization;

namespace EmployeeToFile
{
    public class Employee
    {
        //TODO: Remove _ and make _id => Id
        public int _id;

        public string _FirstName;
        public string _SecondName;
        public string _LastName;
        public string _Position;
        public string _Country;
        public string _City;
        public string _Email;
        public string _Phone;
        public string _PostalCode;
        public DateTime _BirthDate;
        public bool _IsWork;

        public string Serialize()
        {
            return _id.ToString() + ";" + _FirstName + ";" + _SecondName + ";" + _LastName + ";" + _Position
                + ";" + _Country + ";" + _City + ";" + _Email + ";" + _Phone + ";"
                + _PostalCode + ";" + _BirthDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) + ";"
                + _IsWork;
        }

        public static Employee Deserialize(string str)
        {
            string[] data = str.Split(';');
            var emp = new Employee();

            emp._id = Convert.ToInt32(data[0]);
            emp._FirstName = data[1];
            emp._SecondName = data[2];
            emp._LastName = data[3];
            emp._Position = data[4];
            emp._Country = data[5];
            emp._City = data[6];
            emp._Email = data[7];
            emp._Phone = data[8];
            emp._PostalCode = data[9];
            emp._BirthDate = Convert.ToDateTime(data[10]);
            emp._IsWork = Convert.ToBoolean(data[11]);

            return emp;
        }
    }
}
