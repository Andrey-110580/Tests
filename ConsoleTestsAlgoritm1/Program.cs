using System.ComponentModel.Design;
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
            int count11 = 0;
            char[] chars = new char[myStr.Length];
            for (int i = 0; i < myStr.Length; i++)
            {
                if (myStr[i] == 'a')
                {
                    chars[i] = 'b';
                    count11++;
                }
                else
                {
                    chars[i] = myStr[i];
                }
            }

            string newStr = new string(chars);
            Console.WriteLine("Old data : " + myStr);
            Console.WriteLine("New data : " + newStr);
            Console.WriteLine(" Count : " + count11);

            Console.ReadKey();
        }




    }
}
