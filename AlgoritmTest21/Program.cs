namespace AlgoritmTest21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Входная строка содержит произвольную последовательность символов. 
            //Программа должна вывести первое слово этой строки.

            string myStr1 = "  j32odweqjc ij324o oj32";
      
            int i = 0;
            while (i < myStr1.Length && myStr1[i++] == ' ') ;          
            int start = --i;
            while (i < myStr1.Length && myStr1[i++] != ' ') ;

            char[] chars = new char[i -start];
            for (int j = 0; start <i; j++)
            {
                chars[j] = myStr1[start];
                start++;
            }           

            string newStr2 = new string(chars);
            Console.WriteLine("Old data: " + myStr1);
            Console.WriteLine("New data: " + newStr2);

            Console.ReadKey();
        }
    }
}
