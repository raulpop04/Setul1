using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema1
    {
        public static void Solve()
        {
            Console.Write("Introduceti a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double x = -b / a;
                Console.WriteLine($"Solutia ecuatiei {a}x + {b} = 0 este x = {x}");
            }
            else if (b == 0)
            {
                Console.WriteLine("Ecuatia are o infinitate de solutii.");
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutie.");
            }
        }
    }

