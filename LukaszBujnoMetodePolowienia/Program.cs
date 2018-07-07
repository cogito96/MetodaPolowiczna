using LukaszBujnoMetodePolowienia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LukaszBujnoMetodePolowienia.Models.WyszukiwanieMiejscZerowych;
using LukaszBujnoMetodePolowienia.Models.WyszukiwanieMiejscZerowych.MetodyEnum;

namespace LukaszBujnoMetodePolowienia
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodaPolowienia();

            System.Console.WriteLine("Koniec opracji");
            System.Console.ReadLine();
            
        }

        static void MetodaPolowienia()
        {
            //wybieramy metodę wyszukiwania miejsc zerowych //korzystamy z metody fabrykującej 
            IMetodaWyszukiwaniaMiejscaZerowego metodaPolowienia = MetodyWyszukiwaniaMiejscZerowychMetodaFabryczna.StworzMetodeSzukania(MetodyWyszukiwaniaMiejscZerowychEnum.METODA_POLOWIENIA);
            Przedzial przedzial = Parametry.getInstance().przedział;

            if (metodaPolowienia.CzyMetodaSpełniaWarunki(przedzial)) //sprawdzamy czy spelnione zostana watunki algorytmu
            {
                metodaPolowienia.WyznaczMiejsceZerowe(przedzial);
            }
            else
            {
                System.Console.WriteLine("Nie zostały spełnione warunki do użycia algorytmu");
            }
        }
    }
}
