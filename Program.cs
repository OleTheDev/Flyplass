using System;
using System.Linq;

namespace Flyplass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] flyplass =
            {
                "Oslo",
                "Alta",
                "Tromsø",
                "Trondheim",
                "Bodø",
                "USA"
            };

            string[,] routes = 
            {
                {
                    "Oslo", "Alta"
                },
                {
                    "Tromsø","Trondheim"
                },
                {
                    "Bodø","USA"
                }
            };

            string hovedFlyplass = "Tromsø";

            Console.WriteLine("Hvor skal du fra?");
            string flyFra = Console.ReadLine();

            Console.WriteLine("Hvor skal du?");
            string flyTil = Console.ReadLine();

            bool kanFly = false;

            for (int i = 0; i < routes.GetLength(0); i++)
            {
                string kanFlyFra = routes[i, 0];
                string kanFlyTil = routes[i, 1];
              
                if (kanFlyFra == flyFra && flyTil == kanFlyTil)
                {
                    kanFly = true;
                    break;
                } else if (flyFra == hovedFlyplass && !flyplass.Contains(flyTil))
                {
                    kanFly = false;
                    Console.WriteLine("Fant ingen fly plasser til: " + flyTil);
                    break;
                } else if (flyFra == hovedFlyplass && flyplass.Contains(flyTil))
                {
                    kanFly = true;
                    break;
                }
            }

            if (kanFly)
            {
                Console.WriteLine("Ha en fin fly tur!");
            } else
            {
                Console.WriteLine("Ingen fly muligheter!");
            }

            Console.ReadLine();

        }
    }
}
