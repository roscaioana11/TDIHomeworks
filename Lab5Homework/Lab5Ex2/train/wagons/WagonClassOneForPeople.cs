using System;

namespace Lab5Ex2
{
    public class WagonClassOneForPeople : WagonOfPeople
    {
        public WagonClassOneForPeople(int mass, int yearOfManufacture, int numberOfSeats) : base(mass, yearOfManufacture, numberOfSeats)
        {
        }

        public void OpenAirConditioner()
        {
            Console.WriteLine("Starting air conditioner...");
        }

        public void CloseAirConditioner()
        {
            Console.WriteLine("Closing air conditioner...");
        }
    }
}