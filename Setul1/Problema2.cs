using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Problema2
    {
        public static void Solve()
        {
            Console.Write("Introduceti a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Solutiile sunt x1 = {x1} si x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Solutia dubla este x = {x}");
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii reale.");
            }
        }
    }


