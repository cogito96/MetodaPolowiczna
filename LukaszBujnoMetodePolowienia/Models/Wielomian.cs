using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    // podstac wielomianu np y=-2x^3+4x^2-2
    public class Wielomian
    {
        public List<Jednomian> wielomian { get; set; }

        double x { get; set; }
        double y { get; set; }

        public Wielomian()
        {
            wielomian = new List<Jednomian>();
        }

        public double ObliczWartośćY(double x)
        {
            this.x = x;
            ustawWartoscY();
            return y;
        }

        private void ustawWartoscY()
        {
            y = 0;
            foreach (Jednomian wspolczynnik in wielomian)
            {
                y += wspolczynnik.zwrocWartosc(x);
            }
        }
        //metoda wyswietla cały wielomian
        public override string ToString()
        {
            string napisWyjsciowy = "";
            foreach(Jednomian jednomian in wielomian)
            {
                napisWyjsciowy += "(" + jednomian.współczynnikLiczbowy + "x^" + jednomian.stopień + ")+" ;
            }
            napisWyjsciowy = napisWyjsciowy.Remove(napisWyjsciowy.Length - 1);
            return napisWyjsciowy;
        }
    }
}
