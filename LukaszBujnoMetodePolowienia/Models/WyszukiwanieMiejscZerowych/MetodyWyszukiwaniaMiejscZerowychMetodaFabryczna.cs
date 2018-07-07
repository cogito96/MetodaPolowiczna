using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LukaszBujnoMetodePolowienia.Models.WyszukiwanieMiejscZerowych.Metody;
using LukaszBujnoMetodePolowienia.Models.WyszukiwanieMiejscZerowych.MetodyEnum;

namespace LukaszBujnoMetodePolowienia.Models.WyszukiwanieMiejscZerowych
{
    class MetodyWyszukiwaniaMiejscZerowychMetodaFabryczna
    {
        public static IMetodaWyszukiwaniaMiejscaZerowego StworzMetodeSzukania(MetodyWyszukiwaniaMiejscZerowychEnum metodaWyszukiwania)
        {
            IMetodaWyszukiwaniaMiejscaZerowego metodaSzukaniaMiejscaZerowego = null;
            switch (metodaWyszukiwania)
            {
                case MetodyWyszukiwaniaMiejscZerowychEnum.METODA_POLOWIENIA:
                    metodaSzukaniaMiejscaZerowego = new MetodaPolowienia();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Metody Wyszukiwania MiejscZerowych", "Nieznany rodzaj metody");
            }

            return metodaSzukaniaMiejscaZerowego;
        }
    }
}
