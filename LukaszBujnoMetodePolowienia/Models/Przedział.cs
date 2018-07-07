using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    class Przedzial
    {
        public Współrzędna współrzędnaPoczątkowa{ get; set; }
        public Współrzędna współrzędnaKońcowa { get; set; }

        #region Konstruktory
        public Przedzial()
        {
            współrzędnaPoczątkowa = new Współrzędna();
            współrzędnaKońcowa = new Współrzędna();
        }

        public Przedzial(Współrzędna współrzędnaPoczątkowa, Współrzędna współrzędnaKońcowa)
        {
            ustawPrzedział(współrzędnaPoczątkowa, współrzędnaKońcowa);
        }
        #endregion
        //metoda wyznacza srodek przedzailu, zwraca ona wspołrzędną x 
        public double WyznaczSrodek()
        {
            return obliczSrodekPrzedzialu();
        }

        public bool CzyIstniejeMiejsceZeroweWPrzedziale() 
        {
            return sprawdzCzyIstniejeMiejsceZeroweWPrzedziale() ;
        }

        public override string ToString()
        {
            return $"Wspolrzedne przedzialu A: {współrzędnaPoczątkowa.x},{współrzędnaPoczątkowa.y} B: {współrzędnaKońcowa.x},{współrzędnaKońcowa.y}";
        }

        private bool sprawdzCzyIstniejeMiejsceZeroweWPrzedziale()
        {
            return współrzędnaPoczątkowa.y * współrzędnaKońcowa.y <= 0 ? true : false;
        }

        private void ustawPrzedział(Współrzędna współrzędnaPoczątkowa, Współrzędna współrzędnaKoncowa)
        {
            this.współrzędnaPoczątkowa = współrzędnaPoczątkowa;
            this.współrzędnaKońcowa = współrzędnaKoncowa;
        }

        private double obliczSrodekPrzedzialu()
        {
            return (współrzędnaPoczątkowa.x + współrzędnaKońcowa.x) / 2;
        }
    }
}
