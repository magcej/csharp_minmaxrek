using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxRek
{
    class Program
    {
        static int[] tablica = { 1, 4, 3, 2, 4, 9, 5, 7 };     //deklaracja tablicy

        static void Main(string[] args)
        {
            int min = -1;
            int max = -1;

            MinMaxRek(0, 0, ref min, ref max);
            Console.WriteLine("Tablica jednoelementowa {0} {1}", tablica[min], tablica[max] );
            if (tablica[min] == 1) { Console.WriteLine("Min OK"); } else { Console.WriteLine("Min ERROR"); }
            if (tablica[max] == 1) { Console.WriteLine("Max OK"); } else { Console.WriteLine("Max ERROR"); }

            MinMaxRek(0, 1, ref min, ref max);
            Console.WriteLine("Tablica dwuelementowa {0} {1}", tablica[min], tablica[max]);
            if (tablica[min] == 1) { Console.WriteLine("Min OK"); } else { Console.WriteLine("Min ERROR"); }
            if (tablica[max] == 4) { Console.WriteLine("Max OK"); } else { Console.WriteLine("Max ERROR"); }

            MinMaxRek(0, 7, ref min, ref max);
            Console.WriteLine("Tablica trojelementowa {0} {1}", tablica[min], tablica[max]);
            if (tablica[min] == 1) { Console.WriteLine("Min OK"); } else { Console.WriteLine("Min ERROR"); }
            if (tablica[max] == 9) { Console.WriteLine("Max OK"); } else { Console.WriteLine("Max ERROR"); }

        }

        static void MinMaxRek(int lewy, int prawy, ref int index_min, ref int index_max)
        {
            index_min = -10;    //do testow
            index_max = -10;    //do testow

            if (lewy == prawy)  //tablica jednoelementowa
            {
                index_min = lewy;
                index_max = lewy;

                return;
            }

            if (prawy == lewy + 1)  //tablica dwuelementowa
            {
                if (tablica[lewy] > tablica[prawy])
                {
                    index_max = lewy;
                    index_min = prawy;
                }
                else
                {
                    index_max = prawy;
                    index_min = lewy;
                }

                return;
            }

            if (lewy + 1 < prawy)  //tablica wieloelementowa 
            {
                int srodek = (lewy + prawy) / 2;
                int min1 = 0;
                int min2 = 0;
                int max1 = 0;
                int max2 = 0;
                MinMaxRek(lewy, srodek, ref min1, ref max1);
                MinMaxRek(srodek + 1, prawy, ref min2, ref max2);

                if (tablica[min1] <= tablica[min2]) index_min = min1; else index_min = min2;
                if (tablica[max1] >= tablica[max2]) index_max = max1; else index_max = max2;
                return;

            }

        }
        


    }
}
