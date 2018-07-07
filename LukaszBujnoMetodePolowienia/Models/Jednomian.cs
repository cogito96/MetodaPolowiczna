using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
        //wglad jednomianu np. -4x^3
    public class Jednomian
    { 
        public double współczynnikLiczbowy { get; set; }
        public int stopień { get; set; }
        public double zmiennaX { get; set; }

        #region Konstruktory
        public Jednomian()
        {

        }

        public Jednomian(double współczynnikLiczbowy, int stopień)
        {
            this.współczynnikLiczbowy = współczynnikLiczbowy;
            this.stopień = stopień;
        }
        #endregion
        //metoda zwraca wartosc jednomianu przy podanej zmiennej x
        public double zwrocWartosc(double x)
        {
            this.zmiennaX = x;
            return obliczWspołczynnik();
        }

        private double obliczWspołczynnik()
        {
            return Math.Pow(zmiennaX, stopień) * współczynnikLiczbowy;
        }



    }
}
