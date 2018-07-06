using LukaszBujnoMetodePolowienia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukaszBujnoMetodePolowienia
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            Start();




            System.Console.WriteLine("Koniec opracji");
            Console.ReadLine();
        }


        static List<Coordinate> InitCoordinate()
        {
            List<Coordinate> coordinatesList = new List<Coordinate>();

            System.Console.WriteLine("Podaj poczatek przedzialu");
            coordinatesList.Add(CreateCoordinate());

            System.Console.WriteLine("Podaj koniec przedzialu");
            coordinatesList.Add(CreateCoordinate());

            return coordinatesList;
        }

        static void InitPeriod(List<Coordinate> coordinatesList)
        {
            Period period = new Period();
            period.initPeriod(coordinatesList[0], coordinatesList[1]);
            Parameters.getInstance().period = period;
        }

        static bool Start()
        {
            Period period = Parameters.getInstance().period;

            if(period.czyIstniejeMiejsceZerowe())
            {
                for (int i = 0; i < Parameters.getInstance().max; i++)
                {

                    period.znajdzSrodekPrzedziału();
                    if (period.coordinateMiddle.SprawdzCzyJestMiejsceZerowe())
                    {
                        System.Console.WriteLine("Znaleziono miejsce zerowe " + period.coordinateMiddle.x);
                        return true;
                    }
                    else
                    {
                        Period periodLeft;
                        Period periodRight;

                        periodLeft = new Period(period.coordinateA, period.coordinateMiddle);
                        if (periodLeft.czyIstniejeMiejsceZerowe())
                        {
                            period = periodLeft;

                        }
                        else
                        {
                            periodRight = new Period(period.coordinateMiddle, period.coordinateB);
                            period = periodRight;
                        }
                    }
                }
            }
            return false;

        }

        static Coordinate CreateCoordinate()
        {
            Coordinate coordinate = new Coordinate();
            coordinate.init();
            coordinate.SprawdzCzyJestMiejsceZerowe();

            return coordinate;
        }

        static void Init()
        {
            List<Coordinate> coordinatesList;
            coordinatesList = InitCoordinate();
            InitPeriod(coordinatesList);
        }

    }
}
