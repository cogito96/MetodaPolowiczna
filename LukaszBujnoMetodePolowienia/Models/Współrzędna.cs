﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    public class Współrzędna
    {
        public double x { get; set; }
        public double y { get; set; }

        public Współrzędna()
        {

        }

        public void WyznaczWspółrzędnąY (Wielomian wielomian)
        {
            y = wielomian.ObliczWartośćY(x);
        }

        public override string ToString()
        {
            return $"Wspolrzedne punktu, x = {x} oraz y = {y}";
        }

       

    }

}
