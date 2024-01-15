using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Problema18
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Descompunerea în factori primi a numărului {n} este: ");
            DisplayPrimeFactorization(n);
        }

        private static void DisplayPrimeFactorization(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                int count = 0;
                while (number % i == 0)
                {
                    count++;
                    number /= i;
                }

                if (count > 0)
                {
                    Console.Write($"{i}^{count} ");
                }
            }
        }
    }

