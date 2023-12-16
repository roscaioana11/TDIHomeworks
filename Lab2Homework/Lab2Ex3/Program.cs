using System;

namespace Lab2Ex3
{
    class Program
    {
        /**
         * Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati o si afisati i rezultatul
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Read a number from the keyboard to verify if it is Prime number: ");
            int n = int.Parse(Console.ReadLine());
            
            if (!isPrime(n))
            {
                Console.WriteLine($"Your number {n} is NOT a Prime number");
                return;
            }

            Console.WriteLine($"Your number {n} is Prime number");
        }
        
        static bool isPrime(int n)
        { 
            for(int i = 2; i <= n / 2; i++)
            { 
                if(n % i == 0)
                { 
                    return false;
                }
            }
            return true;
        }
    }
}