namespace AlgoritmTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Входная строка содержит произвольную последовательность символов. 
            //Программа должна вывести последнее слово этой строки.

            string myStr3 = "j32odweqjc ij324o oj32";
            char[] chars3 = myStr3.ToCharArray();
            int b3 = myStr3.Length;
            int index = myStr3.LastIndexOf(' ');
            Console.WriteLine("index : " + index);

            char[] charsNew3 = new char[b3 - index - 1];
            int a3 = 0;
            for (int i = index + 1; i < b3; i++)
            {
                charsNew3[a3] = chars3[i];
                a3++;
            }
            string myNewStr3 = String.Concat(charsNew3);
            Console.WriteLine("Lost Word : " + myNewStr3);

            Console.ReadKey();
        }
    }
}
