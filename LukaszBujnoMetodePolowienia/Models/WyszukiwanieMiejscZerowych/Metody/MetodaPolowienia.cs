﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models.WyszukiwanieMiejscZerowych.Metody
{
    class MetodaPolowienia : IMetodaWyszukiwaniaMiejscaZerowego
    {
        private Współrzędna współrzędna { get; set; }
        private Przedzial przedzial { get; set; }

        public bool CzyMetodaSpełniaWarunki(Przedzial przedzial)
        {
            return przedzial.CzyIstniejeMiejsceZeroweWPrzedziale();
        }


        public void WyznaczMiejsceZerowe(Przedzial przedzial)
        {
            this.przedzial = przedzial;
            for (int i = 0; i < Parameters.getInstance().maksymalnaIloscWykonanychOperacji; i++)
            {
                współrzędna = new Współrzędna();
                współrzędna.x = przedzial.WyznaczSrodek();
                współrzędna.WyznaczWspółrzędnąY(Parameters.getInstance().wielomian);

                if (sprawdzCzyMiejsceZerowe())
                {
                    System.Console.WriteLine(współrzędna.ToString());
                    System.Console.WriteLine("Znaleziono miejsce zerowe w punkcie " + współrzędna.x);
                    return;
                }
                else
                {
                    przedzial = wyznaczNowyPrzedział(przedzial, współrzędna);
                }
                System.Console.WriteLine(współrzędna.ToString());
            }
        }

        private bool sprawdzCzyIstniejeMiejsceZerowe()
        {
            return Math.Abs(współrzędna.y) <= Parameters.getInstance().dokładnośćObliczeniowaFunkcji ? true : false;
        }

        private Przedzial wyznaczNowyPrzedział(Przedzial przedzial, Współrzędna współrzędna)
        {
            Przedzial przedzialLewy;
            Przedzial przedzialPrawy;

            przedzialLewy = new Przedzial(przedzial.współrzędnaPoczątkowa, współrzędna);
            przedzialPrawy = new Przedzial(współrzędna, przedzial.współrzędnaKońcowa);

            return przedzialLewy.CzyIstniejeMiejsceZeroweWPrzedziale() ? przedzialLewy : przedzialPrawy;
        }

        private bool sprawdzCzyMiejsceZerowe()
        {
            System.Console.WriteLine("MIEJSCE ZEROWE ");
            return Math.Abs(współrzędna.y) <= Parameters.getInstance().dokładnośćObliczeniowaFunkcji ? true : false;
        }
    }
}
