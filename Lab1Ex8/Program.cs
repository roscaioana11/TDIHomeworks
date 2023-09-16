using System;

namespace Lab1Ex8
{
    /**
     *  Scrieti un program care interschimba valoarea a doua variabile intregi
     */
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = 1;
            int secondInteger = 10;
            Console.WriteLine("First number: {0}\nSecond number: {1}", firstInteger, secondInteger);
            
            // C# 7 tuples approach
            // (firstInteger, secondInteger) = (secondInteger, firstInteger);

            int temp = firstInteger;
            firstInteger = secondInteger;
            secondInteger = temp;
            Console.WriteLine("First number: {0}\nSecond number: {1}", firstInteger, secondInteger);
        }
    }
}