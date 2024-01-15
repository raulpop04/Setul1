using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema17
    {
        public static void Solve()
        {
            Console.Write("Introduceti primul numar: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int num2 = int.Parse(Console.ReadLine());

            int gcd = CalculateGCD(num1, num2);
            int lcm = CalculateLCM(num1, num2);

            Console.WriteLine($"Cel mai mare divizor comun (GCD) este: {gcd}");
            Console.WriteLine($"Cel mai mic multiplu comun (LCM) este: {lcm}");
        }

        private static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        private static int CalculateLCM(int a, int b)
        {
            return (a * b) / CalculateGCD(a, b);
        }
    }

