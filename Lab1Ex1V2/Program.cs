using System;

namespace Lab1Ex1V2
{
    /**
     *  Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
     *  paralelipiped dreptunghic , va afisa volumul lui
     */
    class Program
    {
        /**
         *  A 2-a varianta
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the rectangular parallelepiped: ");
            int parallelepipedLenght;
            bool isNumber = int.TryParse(Console.ReadLine(),out parallelepipedLenght);
            while (!isNumber)
            {
                Console.WriteLine("Not a valid number, try again.\nEnter the lenght of the rectangular parallelepiped: ");
                isNumber = int.TryParse(Console.ReadLine(),out parallelepipedLenght);
            }
            
            Console.WriteLine("Enter the width of the rectangular parallelepiped: ");
            int parallelepipedWidth;
            isNumber = int.TryParse(Console.ReadLine(), out parallelepipedWidth);
            while (!isNumber)
            {
                Console.WriteLine("Not a valid number, try again.\nEnter the width of the rectangular parallelepiped: ");
                isNumber = int.TryParse(Console.ReadLine(),out parallelepipedWidth);
            }
            
            Console.WriteLine("Enter the height of the rectangular parallelepiped: ");
            int parallelepipedHeight; 
            isNumber = int.TryParse(Console.ReadLine(), out parallelepipedHeight);
            while (!isNumber)
            {
                Console.WriteLine("Not a valid number, try again.\nEnter the height of the rectangular parallelepiped: ");
                isNumber = int.TryParse(Console.ReadLine(),out parallelepipedHeight);
            }
            
            int parallelepipedVolume = parallelepipedLenght * parallelepipedWidth * parallelepipedHeight;
            Console.WriteLine($"The rectangular parallelepiped volume is: {parallelepipedVolume}");
        }
    }
}