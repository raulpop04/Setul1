using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema5
    {
        public static void Solve()
        {
            Console.Write("Introduceti numarul: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Introduceti pozitia cifrei: ");
            int position = int.Parse(Console.ReadLine());

            int digit = GetKthDigitFromEnd(number, position);

            Console.WriteLine($"Cifra de pe pozitia {position} de la sfarsitul numarului {number} este {digit}.");
        }

        private static int GetKthDigitFromEnd(int number, int k)
        {
            for (int i = 0; i < k - 1; i++)
            {
                number /= 10;
            }

            return number % 10;
        }
    }

