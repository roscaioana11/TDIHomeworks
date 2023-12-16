using System;

namespace Lab1Ex1V1
{
    /**
     *  Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui paralelipiped dreptunghic , va afisa volumul lui
     */
    class Program
    {
        /**
         *  Prima varianta
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lenght of the rectangular parallelepiped: ");
            int parallelepipedLenght;
            bool isNumber = int.TryParse(Console.ReadLine(),out parallelepipedLenght);
            if (!isNumber)
            {
                Console.WriteLine("Your input for the lenght value is not a number.\nStart the program and try again!");
                return;
            }
            
            Console.WriteLine("Enter the width of the rectangular parallelepiped: ");
            int parallelepipedWidth;
            isNumber = int.TryParse(Console.ReadLine(), out parallelepipedWidth);
            if (!isNumber)
            {
                Console.WriteLine("Your input for the width value is not a number.\nStart the program and try again!");
                return;
            }
            
            Console.WriteLine("Enter the height of the rectangular parallelepiped: ");
            int parallelepipedHeight; 
            isNumber = int.TryParse(Console.ReadLine(), out parallelepipedHeight);
            if (!isNumber)
            {
                Console.WriteLine("Your input for the height value is not a number.\nStart the program and try again!");
                return;
            }
            
            int parallelepipedVolume = parallelepipedLenght * parallelepipedWidth * parallelepipedHeight;
            Console.WriteLine($"The rectangular parallelepiped volume is: {parallelepipedVolume}");
        }
    }
}