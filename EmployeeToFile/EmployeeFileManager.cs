using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToFile
{
    internal class EmployeeFileManager
    {
        const string path = @"G:\app\export.txt";

        private List<Employee> employees = new List<Employee>();


        static void AddToList(List<Employee> employees)
        {
            employees.Add(new Employee());
        }

        public async void Export(List<Employee> employees)
        {
            await File.AppendAllLinesAsync(path, List < Employee > employees);
        }
    }
}
