using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia.Models
{
    class Period
    {
        public Coordinate coordinateA{ get; set; }
        public Coordinate coordinateB { get; set; }
        public Coordinate coordinateMiddle { get; set; }

        public Period()
        {
        }

        public Period(Coordinate coordinateX, Coordinate coordinateY)
        {
            setPeriot(coordinateX, coordinateY);
        }

        public void znajdzSrodekPrzedziału()
        {
            coordinateMiddle = new Coordinate();
            coordinateMiddle.x = (coordinateA.x + coordinateB.x) / 2;
            coordinateMiddle.WyznaczWspolrzednaYPunktu(Parameters.getInstance().polynomial);
        }

        public bool czyIstniejeMiejsceZerowe() 
        {
            return coordinateA.y * coordinateB.y <= 0 ? true : false;
        }

        public void initPeriod(Coordinate coordinateA, Coordinate coordinateB)
        {
            setPeriot(coordinateA, coordinateB);
            ToString();
        }

        public override string ToString()
        {
            return $"Wspolrzedne przedzialu A: {coordinateA.x},{coordinateA.y} B: {coordinateB.x},{coordinateB.y}";
        }

        private void setPeriot(Coordinate coordinateA, Coordinate coordinateB)
        {
            this.coordinateA = coordinateA;
            this.coordinateB = coordinateB;
        }
    }
}
