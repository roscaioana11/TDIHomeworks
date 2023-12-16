using System;

namespace Lab3Ex5
{
    class Program
    {
        /**
         * Scrieti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura
         */
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (GetNumberOfVowels(input) == 0)
            {
                Console.WriteLine("No vowels found!");
            }
            else
            {
                Console.Write($"Number of found vowels: {GetNumberOfVowels(input)}");    
            }
        }

        private static int GetNumberOfVowels(string input)
        {
            string vowels = "aeiou";
            int numberOfVowels = 0;

            input = input.ToLowerInvariant();

            foreach (char character in input)
            {
                if (vowels.Contains(character.ToString()))
                {
                    numberOfVowels++;
                }
            }

            return numberOfVowels;
        }
    }
}