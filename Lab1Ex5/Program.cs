using System;

namespace Lab1Ex5
{
    /**
     * Se citesc doua numere de la tastatura , x,y . Scrieti un program care va afisa cele doua valori in ordine crescatoare
     * • Exemplu: citim ,9,0 Afisam : 0 9
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read 2 numbers from the keyboard");
            int[] numbers = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Input number {i} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (int number in numbers)
            {
                
                Console.Write($"{number} ");
            }
        }
    }
}