using System;

namespace Zajecia_2_PO
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Moj samochod";
            Console.WriteLine(carName);
            Car car1 = new Car("Audi",2000);
            Car car2 = new Car("BMW",2007);
            Console.WriteLine("Marka: " + car1.marka + " " + " Rok produkcji: " +car1.rok);
            /*
            Console.WriteLine("Marka: " + car2.marka + " " + " Rok produkcji: " + car2.rok);
            car1 = car2;
            Console.WriteLine("Marka: " + car1.marka + " " + " Rok produkcji: " + car1.rok);
            Console.ReadKey();*/

        }
    }
}
