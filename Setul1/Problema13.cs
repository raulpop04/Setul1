using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema13
    {
        public static void Solve()
        {
            Console.Write("Introduceti primul an (y1): ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea an (y2): ");
            int y2 = int.Parse(Console.ReadLine());

            int leapYearsCount = CountLeapYears(y1, y2);

            Console.WriteLine($"Numarul de ani bisecti intre {y1} si {y2} este: {leapYearsCount}");
        }

        private static int CountLeapYears(int startYear, int endYear)
        {
            int count = 0;
            for (int year = startYear; year <= endYear; year++)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    count++;
            }

            return count;
        }
    }
