namespace ConsoleMyClass1
{


    internal class Program
    {
        static void Main(string[] args)
        {
            

            Person pers1 = new Person();
            pers1.Id = 1;
            pers1.FirstName = "Andrey";
            pers1.SecondName = "Alexandrovich";
            pers1.LostName = "Ostrizni";
            pers1.Email = "ostriy0511@gmail.com";
            pers1.Title = "amploi and student";

            //

            Person pers2 = new Person();
            pers2.Id = 2;
            pers2.FirstName = "Liliya";
            pers1.SecondName = "Nikolaevna";
            pers1.LostName = "Ostrizna";
            pers1.Email = "striz@gmail.com";
            pers1.Title = "HR director";

            //

            Person pers3 = new Person();
            pers3.Id = 3;
            pers3.FirstName = "Damir";
            pers3.SecondName = "Andreyevich";
            pers3.LostName = "Ostrizni";
            pers3.Email = "damir@gmail.com";
            pers3.Title = "student";

            //

            Person pers4 = new Person();
            pers4.Id = 4;
            pers4.FirstName = "Vsevolod";
            pers4.SecondName = "Andreyevich";
            pers4.LostName = "Ostrizni";
            pers4.Email = "sexa@gmail.com";
            pers4.Title = "schollboy";
        }

        //METHODS

        static void GetPrtson(Person pers)
        {
            if (pers == null)
            {
                return;
            }
        }

    }
}
