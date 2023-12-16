using System;

namespace Lab1Ex7
{
    /**
     *  Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar
     *  In cazul in care numarul este par, programul va afisa “par” iar in caz contrar , “impar"
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Read a number from the keyboard: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine("Odd");
                return;
            }
            
            Console.WriteLine("Even");
        }
    }
}