using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema12
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introduceti inceputul intervalului (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti sfarsitul intervalului (b): ");
            int b = int.Parse(Console.ReadLine());

            int count = CountDivisibleNumbersInRange(n, a, b);

            Console.WriteLine($"Numerele întregi divizibile cu {n} în intervalul [{a}, {b}] sunt: {count}");
        }

        private static int CountDivisibleNumbersInRange(int n, int start, int end)
        {
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % n == 0)
                    count++;
            }

            return count;
        }
    }
