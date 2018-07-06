using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    public class WspółczynnikWielomianu
    {
        public int potega { get; set; }
        public double wartosc { get; set; }
        public double x { get; set; }

        public double zwrocWspołczynnikDlaX(double x)
        {
            this.x = x;
            return obliczWspołczynnik();
        }

        private double obliczWspołczynnik()
        {
            return Math.Pow(x, potega) * wartosc;
        }

    }
}
