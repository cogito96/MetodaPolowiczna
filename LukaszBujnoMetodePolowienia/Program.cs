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


        static List<Współrzędna> InitCoordinate()
        {
            List<Współrzędna> coordinatesList = new List<Współrzędna>();

            System.Console.WriteLine("Podaj poczatek przedzialu");
            coordinatesList.Add(CreateCoordinate());

            System.Console.WriteLine("Podaj koniec przedzialu");
            coordinatesList.Add(CreateCoordinate());

            return coordinatesList;
        }

        static void InitPeriod(List<Współrzędna> coordinatesList)
        {
            Przedzial przedzial = new Przedzial();
            przedzial.initPeriod(coordinatesList[0], coordinatesList[1]);
            Parameters.getInstance().period = przedzial;
        }



        static bool Start()
        {
            Przedzial przedzial = Parameters.getInstance().period;

            if(przedzial.czyIstniejeMiejsceZeroweWPrzedziale())
            {
                for (int i = 0; i < Parameters.getInstance().max; i++)
                {
                    Współrzędna współrzędnaPolowyPrzedzialu = new Współrzędna();
                    współrzędnaPolowyPrzedzialu.x = przedzial.wyznaczSrodekPrzedzialu();
                    współrzędnaPolowyPrzedzialu.WyznaczWspółrzędnąY(Parameters.getInstance().polynomial);
                    if (współrzędnaPolowyPrzedzialu.CzyJestMiejsceZerowe())
                    {
                        System.Console.WriteLine(współrzędnaPolowyPrzedzialu.ToString());
                        System.Console.WriteLine("Znaleziono miejsce zerowe " + współrzędnaPolowyPrzedzialu.x);
                        return true;
                    }
                    else
                    {
                        Przedzial periodLeft;
                        Przedzial periodRight;

                        periodLeft = new Przedzial(przedzial.współrzędnaPoczątkowa, współrzędnaPolowyPrzedzialu);
                        if (periodLeft.czyIstniejeMiejsceZeroweWPrzedziale())
                        {
                            przedzial = periodLeft;

                        }
                        else
                        {
                            periodRight = new Przedzial(współrzędnaPolowyPrzedzialu, przedzial.współrzędnaKońcowa);
                            przedzial = periodRight;
                        }
                    }
                    System.Console.WriteLine(współrzędnaPolowyPrzedzialu.ToString());
                }
            }
            return false;

        }

        static Współrzędna CreateCoordinate()
        {
            Współrzędna coordinate = new Współrzędna();
            coordinate.init();
            coordinate.WyznaczWspółrzędnąY(Parameters.getInstance().polynomial);
            coordinate.CzyJestMiejsceZerowe();

            return coordinate;
        }

        static void Init()
        {
            List<Współrzędna> coordinatesList;
            coordinatesList = InitCoordinate();
            InitPeriod(coordinatesList);
        }

    }
}
