namespace AlogoritmTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программа должна вывести в первой строке самое длинное слово переданной ей строки,
            //а во второй – длину этого слова.
            //Если слов максимальной длины несколько — вывести первое встретившееся слово максимальной длины.


            string myStr4 = "j32odweqjc ij324o oj32 j32odweqjc grd";
            int countWords4 = 0;
            string[] myWords = myStr4.Split(new char[] { ' ' });
            int maxLenght = myWords[0].Length;
            for (int i = 1; i < myWords.Length; i++)
            {
                if (maxLenght < myWords[i].Length)
                {
                    maxLenght = myWords[i].Length;
                }
            }
            Console.WriteLine("Max Long Words:");
            for (int i = 0; i < myWords.Length; i++)
            {
                if (myWords[i].Length == maxLenght)
                {
                    countWords4++;
                }
            }
            for (int i = 0; i < myWords.Length; i++)
            {
                if (myWords[i].Length == maxLenght)
                {
                    Console.WriteLine(myWords[i]);
                    break;
                }
            }
            Console.WriteLine("Count Max Words : " + countWords4);

            Console.ReadKey();
        }
    }
}
