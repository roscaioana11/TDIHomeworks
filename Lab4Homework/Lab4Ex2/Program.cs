using System;

namespace Lab4Ex2
{
    class Program
    {
        /**
         * Scrieti un program care va modela un autoturism. Un autoturism va avea o marca (string), un numar de inmatriculare (string), precum si o capacitate cilindrica (int).
         * Autoturismul va avea:
         * - Campurile corespunzatoare caracteristicilor autoturismului
         * - Un constructor care va initializa campurile acestuia
         * - O metoda GetDescription ”care va returna descrierea acestuia sub forma:“ marca, numarDeInmatriculare, capacitateCilindrica
         * Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii xml pentru metodele publice
         * Creeati doua obiecte de tipul autoturism in functia “Main” apelati le metodele si afisati rezultatul
         */
        public static void Main(string[] args)
        {
            Car car1 = new Car("Audi", "BV20ABC", 2000);
            Console.Write($"Car 1: {car1.GetDescription()}");
            Console.WriteLine();
            
            Car car2 = new Car("Fiat", "CJ30BCD", 1900);
            Console.Write($"Car 2: {car2.GetDescription()}");
        }
    }
}