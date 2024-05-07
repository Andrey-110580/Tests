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

        public static void Export(List<Employee> employeesListt)
        {
            List<string> FromEmployeeToText = new List<string>();

            for (int i = 0; i < employeesListt.Count; i++)
            {
                FromEmployeeToText[i] = employeesListt[i].Serialize();
            }

            File.AppendAllLines(path, FromEmployeeToText);
        }

        public static List<Employee> Import()
        {
            List<Employee> employeesListFromFile = new List<Employee>();
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                string[] fileText = File.ReadAllLines(path);


                foreach (var item in fileText)
                {
                    Employee empl = Employee.Deserialize(item);
                    employeesListFromFile.Add(empl);
                }

            }
            return employeesListFromFile;
        }
    }
}
