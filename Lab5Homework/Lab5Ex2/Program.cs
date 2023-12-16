﻿using System.Collections.Generic;

namespace Lab5Ex2
{
    class Program
    {
        /**
         * Un tren este compus din: o locomotiva si mai multe vagoane de mai multe tipuri:
         * - Locomotiva va avea:
         * -- Putere puterea exprimata in k w
         * -- O metoda de pornire, la apelul careia, aceasta va confirma faptul ca a pornit printr un mesaj afisat in consola,
         * -- O metoda de oprire, la apelul careia, aceasta va confirma faptul ca a oprit printr un mesaj afisat in consola,
         * 
         * - Vagoanele vor avea masa si anul fabricatiei si vor fi de mai multe tipuri:
         * -- Vagoane de marfa, care vor avea:
         * --- tipul marfii (cereale/carbuni/otel) precum si capacitatea in tone
         * 
         * -- Vagoane pentru persoane, care vor avea:
         * --- numar de locuri
         * --- O metoda care va inchide usile si va confirma in consola inchiderea usilor
         * --- O metoda care va deschide usile si va confirma in consola deschiderea usilor
         * 
         * -- Vagoane clasa I, pentru persoane:
         * --- O metoda de pornire a aerului conditionat care va afisa acest lucru pe ecran
         * --- O metoda de oprire a aerului conditionat care va afisa acest lucru pe ecran
         * 
         * - Trenul va avea un nume precum si urmatoarele metode:
         * -- Adauga vagon:
         * --- Aceasta metoda va permite adaugarea vagoanelor la tren
         * 
         * -- Pleaca din gara:
         * --- La aceasta comanda, trenul va inchide usile vagoanelor de persoane si va porni locomotiva
         *
         * -- Opreste in gara:
         * --- La aceasta comanda, trenul va opri locomotiva, va deschide usile vagoanelor de persoane si va opri aerul conditionat in vagoanele clasa 1
         */
        public static void Main(string[] args)
        {
            Locomotive locomotive = new Locomotive(50);
            
            WagonOfMerchandise wagonOfMerchandise = new WagonOfMerchandise(40,2000, MerchandiseType.COAL, 20);
            
            WagonOfPeople wagonOfPeople = new WagonOfPeople(40, 2000, 60);

            WagonClassOneForPeople wagonClassOneForPeople = new WagonClassOneForPeople(40, 2000, 20);

            Train train = new Train("Train", locomotive);
            train.AddWagon(wagonOfMerchandise);
            train.AddWagon(wagonOfPeople);
            train.AddWagon(wagonClassOneForPeople);

            train.Departure();
            train.Arrival();
        }
    }
}