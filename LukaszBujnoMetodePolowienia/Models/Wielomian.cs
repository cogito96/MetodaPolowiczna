using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    public class Wielomian
    {
        public List<WspółczynnikWielomianu> wielomian { get; set; }

        double x { get; set; }
        double y { get; set; }

        public Wielomian()
        {
            wielomian = new List<WspółczynnikWielomianu>();
        }

        public double obliczWartośćY(double x)
        {
            this.x = x;
            ustawWartoscY();
            return y;
        }

        private void ustawWartoscY()
        {
            y = 0;
            foreach (WspółczynnikWielomianu wspolczynnik in wielomian)
            {
                y += wspolczynnik.zwrocWspołczynnikDlaX(x);
            }
        }
    }
}
