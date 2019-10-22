using System;

namespace Projekt_2
{
    public enum Plec {K,M};
    class Osoba {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public Plec plec;
        public Osoba(string imie, string nazwisko, int rokUrodzenia, int waga, int wzrost, bool okulary, Plec _plec) {
            this.plec = _plec;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.waga = waga;
            this.wzrost = wzrost;
            this.okulary = okulary;
        }
        public int obliczWiek()
        {
            int wiek = DateTime.Now.Year - rokUrodzenia;
            return wiek;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {

            Osoba dyrektor = new Osoba("Adam", "Kowalski", 1990, 78, 180, true, Plec.M);
            Console.WriteLine(dyrektor.imie + " " + dyrektor.nazwisko + " " + dyrektor.obliczWiek());
            Console.WriteLine("Dyrektorem jest " + przedrostek(dyrektor.plec) + " " + dyrektor.imie + " "+ dyrektor.nazwisko);
            Console.ReadKey();
        }
        static public string przedrostek(Plec plec) {
            if (plec == Plec.M)
            {
                return "Pan";
            } else
            {
                return "Pani";
            }
        }
        static public float Bmi(int waga, int wzrost)
        {
            int bmi = waga / (wzrost * wzrost);
            return bmi;
        }
        static public string BmiZakres(float bmi)
        {
            if (bmi < 16)
            {
                return "wyglodzenie";
            }
            if (bmi > 16 && bmi < 16.99)
            {
                return "wychudzenie";
            }
            if (bmi > 17 && bmi <18.49)
            {
                return "niedowaga";
            }
            return "cos tam";
        }
    }
}
