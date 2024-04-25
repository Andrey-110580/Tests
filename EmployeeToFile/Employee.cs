using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToFile
{

    public class Employee
    {
        public int _id;
        public string _FirstName;
        public string _SecondName;
        public string _LastName;
        public string _Pozition;
        public string _Country;
        public string _City;
        public string _Email;
        public string _Phone;
        public string _PostalCode;
        public DateTime _BirthDate;
        public bool _IsWork; 




        public string Serialize()
        {
            string _IdStr = _id.ToString();
            // string _BirthStr = _BirthDate.ToString();
            // string _IsWorkStr = _IsWork.ToString();
            string _TextInfo = _IdStr + ";" + _FirstName + ";" + _SecondName + ";" + _LastName + ";" + _Pozition + ";" + _Country + ";" +
                _City + ";" + _Email + ";" + _Phone + ";" + _PostalCode + ";" + _BirthDate + ";" + _IsWork;

            return _TextInfo;

        }

        public static Employee Deserialize(string str)
        {

            string[] data = str.Split(';');
            Employee emp = new Employee();

            emp._id = Convert.ToInt32(data[0]);
            emp._FirstName = data[1];
            emp._SecondName = data[2];
            emp._LastName = data[3];
            emp._Pozition = data[4];
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
