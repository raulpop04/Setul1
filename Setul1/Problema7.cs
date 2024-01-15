using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema7
    {
        public static void Solve()
        {
            Console.Write("Introduceti prima valoare (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti a doua valoare (b): ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Dupa inversare: a = {a}, b = {b}");
        }
    }
