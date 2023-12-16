using System;

namespace Lab2Ex2
{
    class Program
    {
        /**
         * Scrieti o functie care va determina daca un numar este sau nu palindrom
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Read a number from the keyboard to verify if it is a Palindrom: ");
            int n = int.Parse(Console.ReadLine());

            if (!isPalindrom(n))
            {
                Console.WriteLine($"Your number {n} is NOT a Palindrom");
                return;
            }

            Console.WriteLine($"Your number {n} is a Palindrom");
        }

        static bool isPalindrom(int n)
        {
            string stringNr = n + ""; 
            bool isPalindrom = true;
            
            for (int i = 0; i < stringNr.Length / 2; i++) 
            {
                if (stringNr[i] != stringNr[stringNr.Length - 1 - i]) 
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }

    }
}