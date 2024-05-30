namespace AlgoritmTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Входная строка содержит произвольную последовательность символов. 
            //Программа должна вывести последнее слово этой строки.

            string myStr3 = "j32odweqjc ij324o oj32";
            int lastIndex = 0;
            // ищем пробел с конца строки
            for (int i = myStr3.Length-1; i >= 0; i--)
            {
                if (myStr3[i] == ' ' && myStr3[i] != myStr3[i - 1]) // если строка заканчивается пробелами - мы их не считаем
                {
                    lastIndex = i+1;                   
                    break;
                }
            }
            Console.WriteLine("lastIndex " + lastIndex);

            char[] chars3 = new char[myStr3.Length - lastIndex];
            int j = 0;
            for (int i = lastIndex; i < myStr3.Length; i++)
            {
                             
                    chars3[j] = myStr3[i];
                if (j < chars3.Length-1)
                    j++;                
            }
            string lastWord = new string(chars3);
            Console.WriteLine("Last Word : " + lastWord); 
            
 

            Console.ReadKey();
        }
    }
}
