using System;

namespace ConsoleA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pierwsze zadanie   
            string imie = "";
            string przywitanie = "Hello ";
            Console.WriteLine("Podaj imie:");
            imie = Console.ReadLine();
            Console.WriteLine(przywitanie + imie);
            #endregion



            int a = 1;
            int liczbaB = 2;
            if (a > liczbaB)
            {
                Console.WriteLine("A jest wieksze");
            }
            else
            {
                Console.WriteLine("B jest wieksze");
            }
            bool prawda = !true;
            if (prawda == true) {
                Console.WriteLine("To jest prawda");
            } else if (prawda != true)
            {
                Console.WriteLine("To jest falsz");
            }
            if (a > liczbaB & prawda == true)
            {
                Console.WriteLine(" Wow!");
            }
            else if (a < liczbaB | prawda == false) {
                Console.WriteLine("Nope!");
            }
            int inkrementacja = 0;
            for (int i = 0; i < 10; i++) {
                inkrementacja++;
                Console.WriteLine(inkrementacja);
            }



        }
    }
}
