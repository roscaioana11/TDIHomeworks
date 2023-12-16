using System;

namespace Lab3Ex8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            ShowPyramid(number);
        }

        private static void ShowPyramid(int number)
        {
            if (number <= 0)
            {
                return;
            }
            
            ShowPyramid(number - 1);

            for (int i = 0; i < number; i++)
            {
                Console.Write(number);
            }
            Console.WriteLine();
        }
    }
}