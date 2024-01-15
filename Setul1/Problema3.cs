using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Problema3
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti divizorul (k): ");
            int k = int.Parse(Console.ReadLine());

            if (IsDivisible(n, k))
            {
                Console.WriteLine($"{n} se divide cu {k}.");
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}.");
            }
        }

        private static bool IsDivisible(int numerator, int divisor)
        {
            return numerator % divisor == 0;
        }
    }

