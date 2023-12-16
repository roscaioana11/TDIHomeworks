using System;

namespace Lab2Ex4
{
    class Program
    {
        /**
         * Scrieti o functie care afisa piramida numerelor pare, intre 2 si n , n fiind citit de la tastatura
         * 2
         * 4 4
         * 6 6 6
         * 8 8 8 8
         * ...
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Read from the keyboard n, where n is the range: ");    
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            printEvenNumbersOfRightAnglePyramid(n);
        }

        static void printEvenNumbersOfRightAnglePyramid(int range)
        {
            int value = 2;
            for (int i = 1; i <= range; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{value} ");
                }

                value += 2;
                Console.WriteLine();
            }
        }
    }
}