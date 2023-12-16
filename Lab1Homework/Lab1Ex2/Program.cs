using System;

namespace Lab1Ex2
{
    /**
     *  Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura
     */
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            
            Console.WriteLine("Write 3 numbers from the keyboard and calculate the arithmetic mean: ");

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Input number {i} : ");
                int number = int.Parse(Console.ReadLine());
                result += number;
            }

            double average = result / 3;
            Console.WriteLine($"The average is: {average}");
        }
    }
}