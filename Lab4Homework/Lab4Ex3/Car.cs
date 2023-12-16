using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Ex3
{
    public class Car
    {
        private string brand;
        private string licensePlate;
        private int cylindricalCapacity;
        private List<Passenger> passengers = new List<Passenger>();

        public Car(string brand, string licensePlate, int cylindricalCapacity)
        {
            this.brand = brand;
            this.licensePlate = licensePlate;
            this.cylindricalCapacity = cylindricalCapacity;
        }

        public void AddPassenger(Passenger passenger)
        {
            if (passengers.Contains(passenger))
            {
                Console.WriteLine($"Passenger {passenger.GetFullName()} already exists!");
                return;
            }

            passengers.Add(passenger);
        }

        public void DeletePassenger(Passenger passenger)
        {
            if (!passengers.Contains(passenger))
            {
                Console.WriteLine($"Passenger {passenger.GetFullName()} does not exists!");
                return;
            }

            Console.WriteLine($"Passenger {passenger.GetFullName()} was removed.");
            passengers.Remove(passenger);
        }

        public void VerifyPassenger(Passenger passenger)
        {
            if (!passengers.Contains(passenger))
            {
                Console.WriteLine($"Passenger {passenger.GetFullName()} is NOT in the car!");
                return;
            }

            Console.WriteLine($"Passenger {passenger.GetFullName()} is in the car.");
        }

        public string GetDescription()
        {
            StringBuilder description =
                new StringBuilder(
                    $"Brand: {brand}, License Plate: {licensePlate}, Cylindrical Capacity: {cylindricalCapacity}, Passengers: ");
            foreach (Passenger passenger in passengers)
            {
                description.Append($"{passenger.GetFullName()}, ");
            }

            return description.ToString();
        }
    }
}