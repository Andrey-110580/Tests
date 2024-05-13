namespace AlgoritmTest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая определяет, является ли заданная строка
            //(возможно, содержащая пробелы) палиндромом, то есть верно ли,
            //что она после удаления пробелов читается одинаково слева направо и справа налево.
            //Входная строка – последовательность символов, возможно, содержащая пробелы.   ka za k
            //Программа должна вывести слово 'YES', если введённая строка – палиндром, и слово 'NO', если она не является палиндромом.


            Console.WriteLine("Plese Enter Words");
            string myWord6 = Console.ReadLine();
            string newString6 = myWord6.Replace(" ", "");
            int LenNewStr6For = newString6.Length / 2;

            for (int i = 0; i < LenNewStr6For; i++)
            {
                if (newString6[i] != newString6[newString6.Length - 1 - i])
                {
                    Console.WriteLine("This string " + myWord6 + " is not PALINDROM");
                    break;
                }
                else { Console.WriteLine("This string " + myWord6 + " is PALINDROM"); }
            }

            Console.ReadKey();
        }
    }
}
