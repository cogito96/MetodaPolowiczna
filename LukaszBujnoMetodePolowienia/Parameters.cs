using LukaszBujnoMetodePolowienia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia
{
    class Parameters
    {
        public Wielomian wielomian { get; set; }
        public Przedzial przedział;

        public double dokładnośćObliczeniowaFunkcji { get; set; }

        public int maksymalnaIloscWykonanychOperacji { get; set; }

        private static Parameters instance = null;

        private Parameters()
        {
            przedział = new Przedzial();
            wielomian = new Wielomian();
            ustawParametry();
        }

        public static Parameters getInstance()
        {
            if(instance ==  null)
            {
                instance = new Parameters();
            }
            return instance;
        }

        //metod ustawia wszystkie parametry programu, które następnie będą używane to obliczeń
        void ustawParametry()
        {
            System.Console.WriteLine("Podaj dokładność obliczanej wartości pierwiastka funkcji");
            dokładnośćObliczeniowaFunkcji = wczytajWartosc("double");

            System.Console.WriteLine("Podaj początek przedziału");
            przedział.współrzędnaPoczątkowa.x = wczytajWartosc("double");
            przedział.współrzędnaPoczątkowa.WyznaczWspółrzędnąY(this.wielomian);

            System.Console.WriteLine("Podaj koniec przedziału (wartość koncowa musi być wieksza niż początkowa");
            przedział.współrzędnaKońcowa.x = wczytajWartosc("double");
            przedział.współrzędnaPoczątkowa.WyznaczWspółrzędnąY(this.wielomian);

            System.Console.WriteLine("Podaj maksymalną liczbe iteracji obliczeń (po przekroczeniu jej algorymt się zatrzyma");
            maksymalnaIloscWykonanychOperacji = (int)wczytajWartosc("int");

            System.Console.WriteLine("Podaj wielomian");
            dodajWielomian();
        }

        //metoda wczytuje dane z terminalu 
        private double wczytajWartosc(string typWartosciWczytywanej)
        {
            bool walidacja = false;
            double wartoscWyjsciowa = 0;
            do
            {
                try
                {
                    switch (typWartosciWczytywanej)
                    {
                        case "double":
                            wartoscWyjsciowa = Convert.ToDouble(System.Console.ReadLine());
                            break;
                        case "int":
                            wartoscWyjsciowa = Convert.ToInt32(System.Console.ReadLine());
                            break;
                    }
                    walidacja = true;
                }
                catch
                {
                    System.Console.WriteLine("Wpisywana wartość musi być liczbą\n Wpisz odpowiedni znak");
                }
            } while (walidacja == false);
            return wartoscWyjsciowa;
        }
    
        private double dodajWspolczynnik()
        {
            return wczytajWartosc("double");
        }

        private void dodajWielomian()
        {
            do
            {
                System.Console.WriteLine("Podaj wspolczynnik jednomianu (przykładowo -2.8)");
                double wspolczynnikWielomianu = wczytajWartosc("double");

                System.Console.WriteLine("Podaj stopien jednomianu(przykładowo 2)");
                int stopienWielomianu = (int)wczytajWartosc("int");

                Jednomian jednomian = new Jednomian(wspolczynnikWielomianu, stopienWielomianu);
                this.wielomian.wielomian.Add(jednomian);
                System.Console.WriteLine($"Twoj wielomian to: {wielomian.ToString()} \nJezeli chcesz dodac kolejny jednomian, wcisnij 'y' jezeli nie wcisnij 'n'");
            } while (czyDodaćKolejnyJednomian());

        }

        private bool czyDodaćKolejnyJednomian()
        {
            bool czyDodać = true;
            do
            {
                switch (System.Console.ReadLine())
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        System.Console.WriteLine("Zla wartosc. Wpisz 'y' jezeli chcesz dodajc kolejny jednomian lub 'n' gdy nie chcesz");
                        break;
                }
            } while (czyDodać);
            return true;
        }

    }
}
