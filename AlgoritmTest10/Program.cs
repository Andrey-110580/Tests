namespace AlgoritmTest10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая определяет, сколько раз встречается подстрока в символьной строке.
            //Первая строка содержит исходную символьную строку. Вторая строка содержит подстроку-образец.
            //Программа должна вывести одно число – количество вхождений подстроки-образца в исходную строку.
            //abcXYZabcytasdabcas
            //abc
            //3
            string myString10 = "abcXYZabcytasdabcas";
            string subStr10 = "abc";
            int count10 = 0;
            int lenght10 = myString10.Length;
            List<int> indexes = new List<int>();

            for (int i = 0; i < myString10.Length; i++)
            {
                int index10 = myString10.IndexOf(subStr10, i, lenght10 - i);
                Console.WriteLine(index10);

                if (index10 > -1)
                {
                    indexes.Add(index10); 
                }
            }
            Console.WriteLine("indexes count = "+ indexes.Count);
            if (indexes[0] > -1)
            { count10 = 1; }

            if (indexes.Count > 0)
            {
                for (int i = 1;i < indexes.Count; i++)
                {
                if (indexes[i] > 0 &&  indexes[i] > indexes[i-1])
                {
                        count10++;
                    }
            }
            Console.WriteLine("Count : "+count10);
            }
            else { Console.WriteLine("substring not faund in this string"); }

            Console.ReadKey();
        }
    }
}
