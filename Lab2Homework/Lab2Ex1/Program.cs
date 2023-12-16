using System;

namespace Lab2Ex1
{
    class Program
    {
        /**
         * Scrieti o functie care citeşte de la tastatură un şir de n numere naturale şi determină media aritmetică a celor pare, n fiind citit de la tastatra
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Input your numbers. Enter -1 when you finish: ");
            int[] numbers = ReadNumbers();

            double average = CalculateAverageOfEvenNumbers(numbers);
            Console.WriteLine($"Average: {average}");
        }

        private static double CalculateAverageOfEvenNumbers(int[] numbers)
        {
            double sumOfEvenNumbers = 0;
            double evenNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumOfEvenNumbers += numbers[i];
                    evenNumbers++;
                }
            }

            double average = sumOfEvenNumbers / evenNumbers;

            if (double.IsNaN(average))
            {
                return 0;
            }

            return average;
        }

        private static int[] ReadNumbers()
        {
            int[] numbers = new int[0];
            bool exitConsole = false;

            while (!exitConsole)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == -1)
                {
                    exitConsole = true;
                }
                else
                {
                    int[] newNumbers = new int[numbers.Length + 1];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        newNumbers[i] = numbers[i];
                    }

                    newNumbers[newNumbers.Length - 1] = n;
                    numbers = newNumbers;
                }
            }

            return numbers;
        }
    }
}