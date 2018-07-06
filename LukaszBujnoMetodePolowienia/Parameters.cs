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
        public Dictionary<string, int> polynomial { get; set; }

        public double eps { get; set; }

        public int max { get; set; }

        private static Parameters instance = null;

        public Period period;


        private Parameters()
        {
            period = new Period();
            polynomial = new Dictionary<string, int>();
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
            polynomial.Add("x2", 2);
            polynomial.Add("x1", 3);
            polynomial.Add("x0", -8);

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
