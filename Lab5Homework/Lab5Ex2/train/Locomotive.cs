using System;

namespace Lab5Ex2
{
    public class Locomotive
    {
        private int powerInKw;

        public Locomotive(int powerInKw)
        {
            this.powerInKw = powerInKw;
        }

        public void StartLocomotive()
        {
            Console.WriteLine("Start Locomotive!");
        }

        public void StopLocomotive()
        {
            Console.WriteLine("Stop Locomotive!");
        }
    }
}