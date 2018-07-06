using LukaszBujnoMetodePolowienia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia
{
    class Parameters
    {
        public Wielomian polynomial { get; set; }

        public double eps { get; set; }

        public int max { get; set; }

        private static Parameters instance = null;

        public Przedzial period;


        private Parameters()
        {
            period = new Przedzial();
            polynomial = new Wielomian();
            ustaw();
        }

        public static Parameters getInstance()
        {
            if(instance ==  null)
            {
                instance = new Parameters();
            }
            return instance;
        }





        void ustaw()
        {
            polynomial.wielomian.Add("x2", 2);
            polynomial.wielomian.Add("x1", 3);
            polynomial.wielomian.Add("x0", -8);

            max = 10;

            try
            {
                eps = 0.01;
            }catch
            {
                System.Console.WriteLine("Podaj inny parametr");
            }

        }

        
    } 
}
