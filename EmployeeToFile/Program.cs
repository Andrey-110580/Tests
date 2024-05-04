namespace EmployeeToFile
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var e1 = new Employee();
            e1._FirstName = "dsd";

            //
            Console.WriteLine(e1._FirstName);
            var e2 = new Employee();
        }
    }
}
