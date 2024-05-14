namespace AlgoritmTest11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая заменяет расширение у заданного имени файла.
            //Первая строка содержит имя файла, которое нужно изменить. Во второй строке записано нужное расширение.
            //Программа должна вывести изменённое имя файла с заданным расширением.
            //входные данные    
            //qwerty
            //exe
            //выходные данные
            //qwerty.exe
            //входные данные
            //qwetry.old.pas
            //html
            //выходные данные
            //qwetry.old.html

            string fileName1 = "qwerty";
            string fileExtension1 = "exe";
            string fileFullName1 = fileName1 + '.' + fileExtension1;
            Console.WriteLine(fileFullName1);

            string fileName2 = "qwetry.old.pas";
            string fileExtention2 = "html";
            int index = 0;
            char[] chars = fileName2.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] == '.')
                {
                    index = i;
                      break;
                }
            }
            char[] newchars = new char[index+1];
            for (int i = 0; i <= index; i++)
            {
                newchars[i] =chars[i];
            }
            string newFileName2 = new string(newchars);
            string fileFullName2 = newFileName2 + fileExtention2;
            Console.WriteLine(fileFullName2);


            Console.ReadKey();

        }
    }
}
