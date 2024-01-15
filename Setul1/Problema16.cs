using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema16
    {
        public static void Solve()
        {
            Console.Write("Introduceti primul numar (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar (b): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar (c): ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al patrulea numar (d): ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al cincilea numar (e): ");
            int e = int.Parse(Console.ReadLine());

            DisplaySortedNumbers(a, b, c, d, e);
        }

        private static void DisplaySortedNumbers(int a, int b, int c, int d, int e)
        {
            if (a > b)
                Swap(ref a, ref b);
            if (a > c)
                Swap(ref a, ref c);
            if (a > d)
                Swap(ref a, ref d);
            if (a > e)
                Swap(ref a, ref e);
            if (b > c)
                Swap(ref b, ref c);
            if (b > d)
                Swap(ref b, ref d);
            if (b > e)
                Swap(ref b, ref e);
            if (c > d)
                Swap(ref c, ref d);
            if (c > e)
                Swap(ref c, ref e);
            if (d > e)
                Swap(ref d, ref e);

            Console.WriteLine($"Numerele în ordine crescătoare sunt: {a} {b} {c} {d} {e}");
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

