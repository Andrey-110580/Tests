namespace AlogoritmTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программа должна вывести в первой строке самое длинное слово переданной ей строки,
            //а во второй – длину этого слова.
            //Если слов максимальной длины несколько — вывести первое встретившееся слово максимальной длины.


            string myStr4 = "j32odweqjc   ij324o oj32 j32odweqjc grd";
            int lenght = myStr4.Length;
            int countSpace4 = 0;
            //нахожу количество пробелов
            for (int i = 0; i < myStr4.Length; i++)
            {
                if (myStr4[i] == ' ' && i != 0 && myStr4[i - 1] != ' ')
                {
                    countSpace4++;
                }
            }

            if (myStr4[myStr4.Length - 1] == ' ')
            {
                countSpace4--;
            }

            Console.WriteLine("countWords4 = " + countSpace4);
            // нахожу индексы пробелов и записываем в массив
            int[] indexes = new int[countSpace4];
            int ind = 0;
            for (int i = 0; i < myStr4.Length; i++)
            {
                if (myStr4[i] == ' ' && i != 0 && myStr4[i - 1] != ' ')
                {
                    indexes[ind] = i;
                    ind++;
                }
            }
            // нахожу длину отдельных слов в строке
            int[] lenghtsWords = new int[countSpace4 + 1];

            for (int j = 0; j < countSpace4 + 1; j++)
            {
                if (j == 0)
                {
                    lenghtsWords[j] = indexes[j];
                }
                if  (j == countSpace4)
                {
                    lenghtsWords[j] = myStr4.Length - indexes[j - 1];
                }
                else
                {
                    lenghtsWords[j] = indexes[j] - indexes[j - 1];
                }
            }

            for (int i = 0; i < lenghtsWords.Length; i++)
            {
                Console.WriteLine("lenghtsWords =" + lenghtsWords[i]);
            }
                // создаю список массивов чар
               // List<char[]> words;






            

            Console.ReadKey();
        }
    }
}
