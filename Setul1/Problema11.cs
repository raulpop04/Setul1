using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Problema11
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul (n): ");
            int n = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseDigitsOfNumber(n);

            Console.WriteLine($"Cifrele în ordine inversă ale numărului {n} sunt: {reversedNumber}");
        }

        private static int ReverseDigitsOfNumber(int number)
        {
            int reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number /= 10;
            }

            return reversedNumber;
        }
    }
