using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema19
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul: ");
            int number = int.Parse(Console.ReadLine());

            if (IsTwoDigitRepeating(number))
                Console.WriteLine($"{number} este format doar din două cifre care se pot repeta.");
            else
                Console.WriteLine($"{number} nu este format doar din două cifre care se pot repeta.");
        }

        private static bool IsTwoDigitRepeating(int number)
        {
            string numberString = number.ToString();
            return numberString.All(digit => digit == numberString[0] || digit == numberString[1]);
        }
    }

