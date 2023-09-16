using System;

namespace Lab1Ex3
{
    /**
     * Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and find the last digit: ");
            double number = double.Parse(Console.ReadLine());
            double lastDigit = Math.Abs(number) % 10;
            
            Console.WriteLine("Last digit of number {0} is: {1}", number, lastDigit);
        }
    }
}