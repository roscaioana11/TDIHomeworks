using System;

namespace Lab4Ex3
{
    class Program
    {
        /**
         * Autoturismului ii putem adauga pasageri sub forma unor siruri de caractere
         * - "nume prenume"
         * Adaugati autoturismului un set de metode care permit:
         * - Adaugare pasager
         * - Stergere pasager
         * - O metoda care verifica daca un pasager oferit ca parametru a fost adaugat in autoturism
         * - Metoda GetDescription va adauga la descriere numele tuturor pasagerilor din autovehicul
         * •NOTA: in numarul pasagerilor nu este limitat
         */
        public static void Main(string[] args)
        {
            Passenger passenger1 = new Passenger("Rosca", "Ioana");
            Passenger passenger2 = new Passenger("Rosca", "Adriana");
            Passenger passenger3 = new Passenger("Rosca", "Adrian");

            Car car1 = new Car("Audi", "BV20ABC", 2000);
            car1.AddPassenger(passenger1);
            car1.AddPassenger(passenger2);
            car1.AddPassenger(passenger3);
            car1.AddPassenger(passenger3);
            Console.Write($"Car 1: {car1.GetDescription()}");
            Console.WriteLine();

            car1.DeletePassenger(passenger1);
            car1.DeletePassenger(passenger1);
            Console.Write($"Car 1 after removing a passenger: {car1.GetDescription()}");
            Console.WriteLine();
            
            car1.VerifyPassenger(passenger2);
            car1.VerifyPassenger(new Passenger("Rosca", "Ioan"));

            Passenger passenger4 = new Passenger("Pop", "Ioana");
            Passenger passenger5 = new Passenger("Pop", "Adriana");
            Passenger passenger6 = new Passenger("Pop", "Adrian");
            
            Car car2 = new Car("Fiat", "CJ30BCD", 1900);
            car2.AddPassenger(passenger4);
            car2.AddPassenger(passenger5);
            car2.AddPassenger(passenger6);
            car2.AddPassenger(passenger6);
            Console.Write($"Car 2: {car2.GetDescription()}");
            Console.WriteLine();
            
            car2.DeletePassenger(passenger4);
            car2.DeletePassenger(passenger4);
            Console.Write($"Car 2 after removing a passenger: {car2.GetDescription()}");
            Console.WriteLine();
            
            car1.VerifyPassenger(passenger5);
            car1.VerifyPassenger(new Passenger("Pop", "Ioan"));
        }
    }
}