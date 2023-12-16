using System;

namespace Lab5Ex2
{
    public class WagonOfPeople : Wagon
    {
        private int numberOfSeats;
        private bool areDoorsOpen;

        public WagonOfPeople(int mass, int yearOfManufacture, int numberOfSeats) : base(mass, yearOfManufacture)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public void CloseDoors()
        {
            areDoorsOpen = false;
            Console.WriteLine("Closed doors!");
        }

        public void OpenDoors()
        {
            areDoorsOpen = true;
            Console.WriteLine("Opened doors!");
        }
    }
}