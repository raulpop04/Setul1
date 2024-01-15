using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema9
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divizorii numarului {n} sunt:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }

