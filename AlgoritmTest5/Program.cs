namespace AlgoritmTest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая определяет, является ли введённое слово (без пробелов) палиндромом,
            //то есть верно ли, что оно читается одинаково слева направо и справа налево.

            Console.WriteLine("Plese Enter Word");
            string myWord = Console.ReadLine();
            int lenghtMyWord = myWord.Length;
            //           char[]chars5 = myWord.ToCharArray();
            int lengthFor = lenghtMyWord / 2;

            for (int i = 0; i < lengthFor; i++)
            {
                if (myWord[i] != myWord[lenghtMyWord - 1 - i])
                {
                    Console.WriteLine("This word " + myWord + " is not PALINDROM");
                    break;
                }
                else { Console.WriteLine("This word " + myWord + " is PALINDROM"); }
            }

            Console.ReadKey();
        }
    }
}
