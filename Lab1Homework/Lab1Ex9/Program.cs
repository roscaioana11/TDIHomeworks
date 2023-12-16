using System;

namespace Lab1Ex9
{
    /**
     * Folosind instructiunea switch ”, scrieti un program care citind de la tastatura un numar intreg va verifica urmatoarele
     * “ unu ” daca numarul citit este 1
     * “ doi ” daca numarul citit este 2
     * “ trei ” daca numarul citit este 3
     * “ cinci ” daca numarul citit este 5
     * “ opt ” daca numarul citit este 8
     * “ neidentificat ” pentru orice alt caz
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Read a number from the keyboard: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                default:
                    Console.Write("unidentified");
                    break;
            }
        }
    }
}