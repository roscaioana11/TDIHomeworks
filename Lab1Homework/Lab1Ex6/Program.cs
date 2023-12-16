using System;
using System.Collections.Generic;

namespace Lab1Ex6
{
    /**
     * Se citesc trei numere de la tastatura , x,y,z . Scrieti un program care va afisa cele trei valori in ordine descrescatoare
     * • Exemplu: citim 3,9,0 Afisam : 9 3 0
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input how many numbers you want to be read from the keyboard: ");
            int numberLenght = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Read {numberLenght} numbers from the keyboard");
            List<int> numbers = new List<int>();
            for (int i = 0; i < numberLenght; i++)
            {
                Console.Write($"Input number {i + 1} : ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            numbers.Sort();
            numbers.Reverse();
            
            numbers.ForEach(number => Console.Write($"{number} "));
        }
    }
}