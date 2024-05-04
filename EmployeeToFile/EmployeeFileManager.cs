namespace EmployeeToFile
{
    public class EmployeeFileManager
    {
        private const string path = "G:/app/export.txt";

        //TODO: why 1 employee? We expect list/array!
        public void Export(Employee empl)
        {
            var dataToText = empl.Serialize();
            File.AppendAllText(path, dataToText);
            //TODO: remove console write line
            Console.WriteLine("Файл создан");
        }

        //return List/array of Employee
        public static void Import()
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                //Pls use ReadAllLines
                string fileText = File.ReadAllText(path);

                Console.WriteLine(fileText);

                //you don't need it, bacause you will have string[]
                string[] dateFileArr = fileText.Split('\n');
                foreach (var item in dateFileArr)
                {
                    Employee.Deserialize(item);
                }
            }
        }
    }
}
