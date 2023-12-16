using System;

namespace Lab2Ex5
{
    class Program
    {
        /**
         * Se citeste de la tastatura un vector continand n numere intregi, n fiind si el citit la randul sau citit de la tastatura .
         * 
         * Scrieti functii care vor returna:
         * • Cel mai mare numar din vector
         * • Cel mai mic numar din vector
         * • Numerele divizibile cu 3
         * • Scrieti o functie care va inversa elementele vectorului, apelati o si afisati rezultatul
         * • Numerele prime din vector
         * 
         * Apelati functiile si afisati le rezultatele
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Read from the keyboard the vector lenght: ");
            int nLenght = int.Parse(Console.ReadLine());
            int[] numbers = AddNumbers(nLenght);
            SortNumbers(numbers);
            
            Console.WriteLine($"The biggest number is: {numbers[numbers.Length -1]}");
            Console.WriteLine($"The smallest number is: {numbers[0]}");

            Console.Write("Before division to 3: ");
            PrintNumbers(numbers);
            Console.WriteLine();
            
            int[] dividedNumbersBy3 = GetNumbersDivisibleBy3(numbers);
            if (dividedNumbersBy3.Length == 0)
            {
                Console.Write("No number divisible by 3 found!");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Found numbers divisible by 3: ");
                PrintNumbers(dividedNumbersBy3);
                Console.WriteLine();
            }
            
            Console.Write("Before reverse: ");
            PrintNumbers(numbers);
            Console.WriteLine();
            
            int[] reversedNumbers = ReverseNumbers(numbers);
            Console.Write("After reverse: ");
            PrintNumbers(reversedNumbers);
            Console.WriteLine();
            
            Console.Write("Before finding prime numbers: ");
            PrintNumbers(numbers);
            Console.WriteLine();
            
            int[] primeNumbers = GetPrimeNumbers(numbers);
            if (primeNumbers.Length == 0)
            {
                Console.Write("No prime numbers found!");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Found prime numbers: ");
                PrintNumbers(primeNumbers);
                Console.WriteLine();
            }
        }

        private static int[] GetPrimeNumbers(int[] numbers)
        {
            int foundPrimeNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 2 && isPrime(numbers[i]))
                {
                    foundPrimeNumbers++;
                }
            }
            
            if (foundPrimeNumbers == 0)
            {
                return new int[0];
            }

            int[] primeNumbers = new int[foundPrimeNumbers];
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 2 && isPrime(numbers[i]))
                {
                    primeNumbers[counter] = numbers[i];
                    counter++;
                }
            }

            return primeNumbers;
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

        private static int[] ReverseNumbers(int[] numbers)
        {
            int[] reversedNumbers = new int[numbers.Length];
            
            for (int i = numbers.Length - 1; i >= 0 ; i--)
            {
                reversedNumbers[reversedNumbers.Length - i - 1] = numbers[i];
            }

            return reversedNumbers;
        }

        private static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }

        private static int[] GetNumbersDivisibleBy3(int[] numbers)
        {
            int foundNumbersDividedBy3 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    foundNumbersDividedBy3++;
                }
            }
            
            if (foundNumbersDividedBy3 == 0)
            {
                return new int[0];
            }

            int[] dividedNumbersBy3 = new int[foundNumbersDividedBy3];
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    dividedNumbersBy3[counter] = numbers[i];
                    counter++;
                }
            }

            return dividedNumbersBy3;
        }

        private static void SortNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = i; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    { 
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        private static int[] AddNumbers(int nLenght)
        {
            int[] numbers = new int[nLenght];
            Console.WriteLine("Input numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = int.Parse(Console.ReadLine());
                numbers[i] = n;
            }

            return numbers;
        }
    }
}