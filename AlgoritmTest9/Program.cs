namespace AlgoritmTest9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая заменяет в символьной строке все вхождения одной подстроки на другую. Используйте процедуру.
            // Первая входная строка содержит символьную строку, которую нужно обработать.
            // Во второй и третьей строках записаны соответственно подстрока-образец (которую нужно менять) и подстрока-замена.
            // Программа должна вывести обработанную символьную строку, в которой все вхождения подстроки-образца заменены на подстроку-замену.
            //abcDEFabcgh  
            //abc
            //XYZ
            //XYZDEFXYZgh
            string oldStr9 = "abcDEFabcgh";
            string subStrOld = "abc";
            string subStrNew = "XYZ";

            static string NewStr9(string str, string str1, string str2)
            {
                string newStr9 = str.Replace(str1, str2);
                return newStr9;
            }

            string str9 = NewStr9(oldStr9, subStrOld, subStrNew);
            Console.WriteLine("Old string is " + oldStr9);
            Console.WriteLine("New string is " + str9);

            Console.ReadKey();
        }
    }
}
