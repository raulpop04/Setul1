using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema8
    {
        public static void Solve()
        {
            Console.Write("Introduceti prima valoare (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti a doua valoare (b): ");
            int b = int.Parse(Console.ReadLine());


            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Dupa inversare: a = {a}, b = {b}");
        }
    }

