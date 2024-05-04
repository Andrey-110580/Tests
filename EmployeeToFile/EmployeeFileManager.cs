using System.Collections.Generic;

namespace EmployeeToFile
{
    public class EmployeeFileManager
    {
        private const string path = "G:/app/export.txt";

        //TODO: why 1 employee? We expect list/array!

       List<Employee> employeesList = new List<Employee>();

        public void InsertEmployeeToList(Employee employee) 
        {
           employeesList.Add(employee);
        }

        public void Export(Employee employeesList)
        {
            var dataToText = employeesList.Serialize();
            File.AppendAllText(path, dataToText);

        }

        public static List<Employee> Import()
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                string[] fileText = File.ReadAllLines(path);

                List<Employee> employeesListFromFile = new List<Employee>(fileText.Length);

                foreach (var item in fileText)
                {                   
                    Employee.Deserialize(item);
                }
                
            }
            return employeesListFromFile;
        }
    }
}
