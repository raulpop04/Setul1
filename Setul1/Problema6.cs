using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema6
    {
        public static void Solve()
        {
            Console.Write("Introduceti lungimea primei laturi: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introduceti lungimea celei de-a doua laturi: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Introduceti lungimea celei de-a treia laturi: ");
            double c = double.Parse(Console.ReadLine());

            if (IsTriangle(a, b, c))
                Console.WriteLine("Cele trei lungimi pot forma un triunghi.");
            else
                Console.WriteLine("Cele trei lungimi nu pot forma un triunghi.");
        }

        private static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }

