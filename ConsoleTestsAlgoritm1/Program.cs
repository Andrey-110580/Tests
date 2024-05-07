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


            //Входная строка содержит произвольную последовательность символов. 
            //Программа должна вывести первое слово этой строки.

            string myStr1 = "j32odweqjc ij324o oj32";
            char[] chars1 = myStr1.ToCharArray();
            int b = myStr1.Length;
            int count = 0;

            for (int i = 0; i < b; i++)
            {
                if (chars1[i] != ' ')
                {
                    count++;
                }
                else
                {
                    count = i;
                    break;
                }
            }
            Console.WriteLine(count);
            char[] chars2 = new char[count];

            for (int i = 0; i < count; i++)
            {
                chars2[i] = chars1[i];
            }
            string newStr2 = String.Concat(chars2);

            Console.WriteLine("Old data : " + myStr1);
            Console.WriteLine("New data : " + newStr2);

            //Входная строка содержит произвольную последовательность символов. 
            //Программа должна вывести последнее слово этой строки.

            string myStr3 = "j32odweqjc ij324o oj32";
            char[] chars3 = myStr3.ToCharArray();
            int b3 = myStr3.Length;
            int index = myStr3.LastIndexOf(' ');
            Console.WriteLine("index : " + index);

            char[] charsNew3 = new char[b3-index-1];
            int a3 = 0;
            for (int i = index+1; i < b3; i++)
            {
                charsNew3[a3] = chars3[i];
                a3++;
            }
            string myNewStr3 = String.Concat(charsNew3);
            Console.WriteLine("Lost Word : " + myNewStr3);

            //Программа должна вывести в первой строке самое длинное слово переданной ей строки,
            //а во второй – длину этого слова.
            //Если слов максимальной длины несколько — вывести первое встретившееся слово максимальной длины.


            string myStr4 = "j32odweqjc ij324o oj32 j32odweqjc grd";
             int countWords4 =0;
            string[] myWords = myStr4.Split(new char[] { ' ' });
            int maxLenght = myWords[0].Length;
            for (int i = 1;i < myWords.Length;i++)
            {
                if (maxLenght < myWords[i].Length)
                {
                    maxLenght = myWords[i].Length;
                }
            }
            Console.WriteLine("Max Long Words :");
            for (int i = 0;i < myWords.Length;i++)
            { 
                if(myWords[i].Length == maxLenght)
                {
                    countWords4++;
                    Console.WriteLine(myWords[i]);
                }
            }
            Console.WriteLine("Count Max Words : " + countWords4);


            Console.ReadKey();


        }
    }
}
