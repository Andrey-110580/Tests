namespace AlgoritmTest7
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            string myStr7 = "C:\\WINDOWS\\MEDIA\\work.wav";
            Console.WriteLine(myStr7);

            string[] Mywords7 = myStr7.Split("\\");
            foreach (var item in Mywords7)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
