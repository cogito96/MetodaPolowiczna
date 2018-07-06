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
            WspółczynnikWielomianu współczynnikWielomianu1 = new WspółczynnikWielomianu();
            WspółczynnikWielomianu współczynnikWielomianu2 = new WspółczynnikWielomianu();
            WspółczynnikWielomianu współczynnikWielomianu3 = new WspółczynnikWielomianu();

            współczynnikWielomianu1.potega = 2;
            współczynnikWielomianu2.potega = 1;
            współczynnikWielomianu3.potega = 0;

            współczynnikWielomianu1.wartosc = 2;
            współczynnikWielomianu2.wartosc = 3;
            współczynnikWielomianu3.wartosc = -8;

            polynomial.wielomian.Add(współczynnikWielomianu1);
            polynomial.wielomian.Add(współczynnikWielomianu2);
            polynomial.wielomian.Add(współczynnikWielomianu3);

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
