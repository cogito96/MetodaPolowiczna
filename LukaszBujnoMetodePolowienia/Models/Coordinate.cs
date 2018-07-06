using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    public class Coordinate
    {
        public double x { get; set; }
        public double y { get; set; }

        public Coordinate()
        {

        }
            
        //funkcja ktora ma za zadanie wyznaczyc punkt na osi y, mając podany wspołrzędną X oraz funkcję         
        public void WyznaczWspolrzednaYPunktu(Dictionary<string,int> polynomialDictionary)
        { 
            this.y = 0;
            foreach (KeyValuePair<string, int> polynomial in polynomialDictionary)
            {
                this.y += policzWspołczynnik(polynomial);
            }
            return;
        }

        public bool SprawdzCzyJestMiejsceZerowe()
        {
            double aa = Parameters.getInstance().eps;
            return Math.Abs(y) < Parameters.getInstance().eps ? true : false;
        }

        public void init()
        {
            x = Double.Parse(System.Console.ReadLine());
            WyznaczWspolrzednaYPunktu(Parameters.getInstance().polynomial);
            ToString();
        }


        public override string ToString()
        {
            return $"Wspolrzedne punktu, x = {x} oraz y = {y}";
        }

        private double policzWspołczynnik(KeyValuePair<string, int> wpolczynnik)
        {
            int potega = Int32.Parse(Convert.ToString(wpolczynnik.Key[1]));
            return Math.Pow(x, Convert.ToInt32(potega)) * wpolczynnik.Value;
        }
    }

}
