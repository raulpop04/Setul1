using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Problema21
    {
        public static void Solve()
        {
            Console.WriteLine("Gândiți-vă la un număr între 1 și 1024.");
            int lowerBound = 1;
            int upperBound = 1024;
            int guessedNumber = (lowerBound + upperBound) / 2;
            string userResponse;

            do
            {
                Console.WriteLine($"Numărul la care vă gândiți este mai mare sau egal decât {guessedNumber}? (y/n)");
                userResponse = Console.ReadLine().ToLower();

                if (userResponse == "y")
                {
                    lowerBound = guessedNumber + 1;
                }
                else if (userResponse == "n")
                {
                    upperBound = guessedNumber - 1;
                }
                else
                {
                    Console.WriteLine("Modificați răspunsul.");
                }

                guessedNumber = (lowerBound + upperBound) / 2;

            } while (lowerBound <= upperBound);

            Console.WriteLine($"Numărul la care v-ați gândit este {guessedNumber}");
        }


    }

