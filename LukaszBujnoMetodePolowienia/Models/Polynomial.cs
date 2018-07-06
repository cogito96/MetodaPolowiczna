using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    class Polynomial
    {
        Dictionary<string, int> polynomial { get; set; }



        private double policzWspołczynnik(KeyValuePair<string, int> wpolczynnik)
        {
            int potega = Int32.Parse(Convert.ToString(wpolczynnik.Key[1]));
            return Math.Pow(x, Convert.ToInt32(potega)) * wpolczynnik.Value;
        }


    }
}
