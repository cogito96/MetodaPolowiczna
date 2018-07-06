using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    public class Wielomian
    {
        public Dictionary<string, int> wielomian { get; set; }

        double x { get; set; }
        double y { get; set; }

        public Wielomian()
        {
            wielomian = new Dictionary<string, int>();
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
            foreach (KeyValuePair<string, int> polynomial in wielomian)
            {
                y += obliczWspołczynnik(polynomial);
            }
        }

        private double obliczWspołczynnik(KeyValuePair<string,int> wspolczynnik)
        {
            int potega = zwrocPotegęWspółczynnika(wspolczynnik.Key[1].ToString());       //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            return zwrocWartoscWspolczynnika(potega, wspolczynnik.Value);

        }

        private int zwrocPotegęWspółczynnika(string wpolczynnik)
        {
            return Int32.Parse(Convert.ToString(wpolczynnik));
        }

        private double zwrocWartoscWspolczynnika(int potega, int wartośćWspółczynnika)
        {
            return Math.Pow(x, potega) * wartośćWspółczynnika;
        }

    }
}
