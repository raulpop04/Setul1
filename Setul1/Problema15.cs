using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema15
    {
        public static void Solve()
        {
            Console.Write("Introduceti primul numar (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar (b): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar (c): ");
            int c = int.Parse(Console.ReadLine());

            DisplaySortedNumbers(a, b, c);
        }

        private static void DisplaySortedNumbers(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                Console.Write($"{a} ");
                if (b <= c)
                    Console.WriteLine($"{b} {c}");
                else
                    Console.WriteLine($"{c} {b}");
            }
            else if (b <= a && b <= c)
            {
                Console.Write($"{b} ");
                if (a <= c)
                    Console.WriteLine($"{a} {c}");
                else
                    Console.WriteLine($"{c} {a}");
            }
            else
            {
                Console.Write($"{c} ");
                if (a <= b)
                    Console.WriteLine($"{a} {b}");
                else
                    Console.WriteLine($"{b} {a}");
            }
        }
    }

