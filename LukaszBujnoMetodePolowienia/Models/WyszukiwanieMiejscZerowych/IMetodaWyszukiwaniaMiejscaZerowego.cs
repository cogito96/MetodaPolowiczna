using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models.WyszukiwanieMiejscZerowych
{
    interface IMetodaWyszukiwaniaMiejscaZerowego 
    {
        void WyznaczMiejsceZerowe(Przedzial przedzial);
        bool CzyMetodaSpełniaWarunki(Przedzial przedzial); // metoda ma na celu sprawdzenia, czy algorytm może w ogóle zadziałać 


    }
}
