using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema14
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul (n): ");
            int n = int.Parse(Console.ReadLine());

            if (IsPalindrome(n))
                Console.WriteLine($"{n} este un numar palindrom.");
            else
                Console.WriteLine($"{n} nu este un numar palindrom.");
        }

        private static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number /= 10;
            }

            return originalNumber == reversedNumber;
        }
    }
