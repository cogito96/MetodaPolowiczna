using LukaszBujnoMetodePolowienia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia
{
    class Program
    {
        static void Main(string[] args)
        {

            MetodaPolowienia();

            System.Console.WriteLine("Koniec opracji");
            System.Console.ReadLine();
            
        }

        static bool MetodaPolowienia()
        {
            Przedzial przedzial = Parameters.getInstance().przedział;

            if (przedzial.CzyIstniejeMiejsceZeroweWPrzedziale())
            {
                for (int i = 0; i < Parameters.getInstance().maksymalnaIloscWykonanychOperacji; i++)
                {
                    Współrzędna współrzędnaPolowyPrzedzialu = new Współrzędna();
                    współrzędnaPolowyPrzedzialu.x = przedzial.WyznaczSrodek();
                    współrzędnaPolowyPrzedzialu.WyznaczWspółrzędnąY(Parameters.getInstance().wielomian);

                    if (współrzędnaPolowyPrzedzialu.CzyJestMiejsceZerowe())
                    {
                        System.Console.WriteLine(współrzędnaPolowyPrzedzialu.ToString());
                        System.Console.WriteLine("Znaleziono miejsce zerowe " + współrzędnaPolowyPrzedzialu.x);
                        return true;
                    }
                    else
                    {
                        wyznaczNowyPrzedział(przedzial, współrzędnaPolowyPrzedzialu);
                    }
                    System.Console.WriteLine(współrzędnaPolowyPrzedzialu.ToString());
                }
            }
            return false;
        }

        static Przedzial wyznaczNowyPrzedział(Przedzial przedzial, Współrzędna współrzędna)
        {
            Przedzial przedzialLewy;
            Przedzial przedzialPrawy;

            przedzialLewy = new Przedzial(przedzial.współrzędnaPoczątkowa, współrzędna);
            przedzialPrawy = new Przedzial(współrzędna, przedzial.współrzędnaKońcowa);

            return przedzialLewy.CzyIstniejeMiejsceZeroweWPrzedziale() ? przedzialLewy : przedzialPrawy;
        }

    }
}
