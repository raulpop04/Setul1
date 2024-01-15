using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Problema4
    {
        public static void Solve()
        {
            Console.Write("Introduceti anul: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine($"{year} este an bisect.");
            else
                Console.WriteLine($"{year} nu este an bisect.");
        }
    }

