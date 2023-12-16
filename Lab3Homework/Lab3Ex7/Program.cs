using System;

namespace Lab3Ex7
{
    class Program
    {
        /**
         * Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n, apelati o si afisati i rezultatul.
         */
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write($"Sum: {GetSumOfNumbers(number)}");
        }

        private static int GetSumOfNumbers(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number + GetSumOfNumbers(number - 1);
        }
    }
}