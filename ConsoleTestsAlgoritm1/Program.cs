using System.Security.Cryptography.X509Certificates;

namespace ConsoleTestsAlgoritm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // замена букв в строке
            //Программа должна заменить во всей строке строчные буквы a на буквы b и вывести в первой строке получившуюся символьную строку,
            //а во второй – количество выполненных замен.

            string myStr = "klhfesfE4ADa";
            char[] chars = myStr.ToCharArray();
            int a = myStr.Length;
            int count1 = 0;
            for (int i = 0; i < a; i++)
            {
                if (chars[i] == 'a')
                {
                    chars[i] = 'b';
                    count1++;
                }
            }
            string newStr = String.Concat(chars);
            Console.WriteLine("Old data : " + myStr);
            Console.WriteLine("New data : " + newStr);
            Console.WriteLine(" Count : " + count1);

            Console.ReadKey();
        }
    }
}
