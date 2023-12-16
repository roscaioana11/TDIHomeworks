using System;

namespace Lab1Ex4
{
    /**
     * Scrieti un program care va afisa semnul unui numar citit de la tastatura
     * • Daca numarul este pozitiv , va afisa "+"
     * • Daca numarul este negativ , va afisa "-"
     * • Daca numarul este 0, va afisa “0"
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("+");
            } else if (number < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}