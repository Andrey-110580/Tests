using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToFile
{
    public class EmployeeFileManager
    {
        const string path = @"G:\app\export.txt";
        private string DataToText;

        private string[] EmplArr = new string[Employee.Counter];

        // private List<Employee> employees = new List<Employee>();


       // static void AddToList (List<Employee> employees )
      //  {
      //      employees.Add ( new Employee() );
      //  }

        public  void Export(Employee empl)
        {
            DataToText = empl.Serialise();
            File.AppendAllText(path, DataToText);
            Console.WriteLine(  "Файл создан");
        }

        public static void Import() 
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                string fileText = File.ReadAllText(path);

                Console.WriteLine( fileText );

                string[] dateFileArr = fileText.Split('\n');
                foreach (var item in dateFileArr)
                {
                    Employee.Deserialise(item);
                }
            }
            
        }

    }
}
