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

            char[] charsNew3 = new char[b3 - index - 1];
            int a3 = 0;
            for (int i = index + 1; i < b3; i++)
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
            Console.WriteLine("Max Long Words :");
            for (int i = 0; i < myWords.Length; i++)
            {
                if (myWords[i].Length == maxLenght)
                {
                    countWords4++;
                    Console.WriteLine(myWords[i]);
                }
            }
            Console.WriteLine("Count Max Words : " + countWords4);

            //Напишите программу, которая определяет, является ли введённое слово (без пробелов) палиндромом,
            //то есть верно ли, что оно читается одинаково слева направо и справа налево.

            Console.WriteLine("Plese Enter Word");
            string myWord = Console.ReadLine();
            int lenghtMyWord = myWord.Length;
            //           char[]chars5 = myWord.ToCharArray();
            int lengthFor = lenghtMyWord / 2;

            for (int i = 0; i < lengthFor; i++)
            {
                if (myWord[i] != myWord[lenghtMyWord - 1 - i])
                {
                    Console.WriteLine("This word " + myWord + " is not PALINDROM");
                    break;
                }
                else { Console.WriteLine("This word " + myWord + " is PALINDROM"); }
            }

            //Напишите программу, которая определяет, является ли заданная строка
            //(возможно, содержащая пробелы) палиндромом, то есть верно ли,
            //что она после удаления пробелов читается одинаково слева направо и справа налево.
            //Входная строка – последовательность символов, возможно, содержащая пробелы.   ka za k
            //Программа должна вывести слово 'YES', если введённая строка – палиндром, и слово 'NO', если она не является палиндромом.


            Console.WriteLine("Plese Enter Words");
            string myWord6 = Console.ReadLine();
            string newString6 = myWord6.Replace(" ", "");
            int LenNewStr6For = newString6.Length / 2;

            for (int i = 0; i < LenNewStr6For; i++)
            {
                if (newString6[i] != newString6[newString6.Length - 1 - i])
                {
                    Console.WriteLine("This string " + myWord6 + " is not PALINDROM");
                    break;
                }
                else { Console.WriteLine("This string " + myWord6 + " is PALINDROM"); }
            }

            //В операционной системе Windows путь к файлу состоит из имени логического диска и названий каталогов,
            //в которых находится этот файл. Части пути разделены знаками "\" (обратный слэш).
            //Требуется разбить заданный путь к файлу на части — имя диска и названия каталогов.  
            //Программа должна вывести имя диска и названия всех каталогов, составляющих путь.
            //Каждый элемент выводится в отдельной строке.
            //C:\WINDOWS\MEDIA\work.wav
            //C:
            //WINDOWS
            //MEDIA
            //work.wav

            string myStr7 = "C:'\'WINDOWS'\'MEDIA'\'work.wav";
            Console.WriteLine(myStr7);

            string[] Mywords7 = myStr7.Split("'\'");
            foreach (var item in Mywords7)
            {
                Console.WriteLine(item);
            }


            // Напишите программу, которая преобразует строку, содержащую имя, отчество и фамилию человека,
            // к форме < фамилия > < инициалы >
            //Входная строка содержит имя, отчество и фамилию, разделённые одиночными пробелами.
            //Donald Ervin Knuth
            //Knuth D.E.

            string longName = "Donald Ervin Knuth";
            string[] words8 = longName.Split(" ");
            char[] chars81 = words8[1].ToCharArray();
            char[] shars82 = words8[2].ToCharArray();
            string ShotName = words8[0] + " " + chars81[0] + "." + shars82[0] + ".";
            Console.WriteLine("longName is " + longName);
            Console.WriteLine("ShotName is " + ShotName);


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

            for (int i = 0; i < myString10.Length; i++)
            {
                int index10 = myString10.IndexOf(subStr10,i,lenght10-i);
                Console.WriteLine(index10);
            }
                

           Console.WriteLine("ZOPA " + count10);





            Console.ReadKey();


        }
    }
}
