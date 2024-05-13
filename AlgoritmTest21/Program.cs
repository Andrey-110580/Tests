namespace AlgoritmTest21
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Old data: " + myStr1);
            Console.WriteLine("New data: " + newStr2);

            Console.ReadKey();
        }
    }
}
