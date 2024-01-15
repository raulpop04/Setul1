using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema20
    {
        public static void Solve()
        {
            Console.Write("Introduceti numaratorul (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numitorul (n): ");
            int n = int.Parse(Console.ReadLine());

            string decimalFraction = CalculateDecimalFraction(m, n);
            Console.WriteLine($"Fractia {m}/{n} este în format zecimal: {decimalFraction}");
        }

        private static string CalculateDecimalFraction(int numerator, int denominator)
        {
            if (denominator == 0)
                return "Numitorul nu poate fi zero.";

            if (numerator == 0)
                return "0";

            if (IsNonRepeating(denominator))
                return ((double)numerator / denominator).ToString();

            Dictionary<long, int> remainderIndices = new Dictionary<long, int>();
            List<char> decimalDigits = new List<char>();
            long remainder = numerator % denominator;

            while (remainder != 0 && !remainderIndices.ContainsKey(remainder))
            {
                remainderIndices[remainder] = decimalDigits.Count;
                remainder *= 10;
                decimalDigits.Add((char)(remainder / denominator + '0'));
                remainder %= denominator;
            }

            if (remainder == 0)
            {
                return $"{numerator / denominator}.{new string(decimalDigits.ToArray())}";
            }
            else
            {
                int nonRepeatingLength = remainderIndices[remainder];
                string nonRepeatingPart = new string(decimalDigits.Take(nonRepeatingLength).ToArray());
                string repeatingPart = new string(decimalDigits.Skip(nonRepeatingLength).ToArray());

                return $"{numerator / denominator}.{nonRepeatingPart}({repeatingPart})";
            }
        }

        private static bool IsNonRepeating(int denominator)
        {
            return denominator == 1 || IsPowerOfTwoOrFive(denominator);
        }

        private static bool IsPowerOfTwoOrFive(int number)
        {
            while (number % 2 == 0)
                number /= 2;

            while (number % 5 == 0)
                number /= 5;

            return number == 1;
        }
    }

