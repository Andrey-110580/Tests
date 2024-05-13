namespace AlgoritmTest8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая преобразует строку, содержащую имя, отчество и фамилию человека,
            // к форме < фамилия > < инициалы >
            //Входная строка содержит имя, отчество и фамилию, разделённые одиночными пробелами.
            //Donald Ervin Knuth
            //Knuth D.E.

            string longName = "Donald Ervin Knuth";
            string[] words8 = longName.Split(" ");
            char[] chars81 = words8[1].ToCharArray();
            char[] shars82 = words8[2].ToCharArray();
            string ShotName = words8[0] + " " + chars81[0] + "." + shars82[0] + ".";
            Console.WriteLine("longName is " + longName);
            Console.WriteLine("ShotName is " + ShotName);

            Console.ReadKey();
        }
    }
}
