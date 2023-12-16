using System;
using System.Collections.Generic;

namespace Lab5Ex2
{
    public class Train
    {
        private string name;
        private Locomotive locomotive;
        private List<Wagon> wagons = new List<Wagon>();
        public Train(string name, Locomotive locomotive)
        {
            this.name = name;
            this.locomotive = locomotive;
        }

        public void AddWagon(Wagon wagon)
        {
            wagons.Add(wagon);
            
        }

        public void Departure()
        {
            foreach (Wagon wagon in wagons)
            {
                if (wagon is WagonOfPeople)
                {
                    WagonOfPeople wagonOfPeople = wagon as WagonOfPeople;
                    wagonOfPeople.CloseDoors();
                }
            }
            locomotive.StartLocomotive();
        }

        public void Arrival()
        {
            locomotive.StopLocomotive();
            foreach (Wagon wagon in wagons)
            {
                if(wagon is WagonClassOneForPeople)
                {
                    WagonClassOneForPeople wagonClassOneForPeople = wagon as WagonClassOneForPeople;
                    wagonClassOneForPeople.CloseAirConditioner();
                } else if (wagon is WagonOfPeople)
                {
                    WagonOfPeople wagonOfPeople = wagon as WagonOfPeople;
                    wagonOfPeople.OpenDoors();
                }
            }
        }
    }
}