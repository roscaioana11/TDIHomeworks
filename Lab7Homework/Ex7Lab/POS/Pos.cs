using System;

namespace Ex7Lab.POS
{
    public class Pos: IPos
    {
        private double sumaDePlata;
        public void IntroduSumaDePlata(double suma)
        {
            this.sumaDePlata = suma;
            Console.WriteLine($"Am incarcat suma de plata {suma}");
        }
        
        public void PlatesteContactless(IContactlessPay device)
        {
            device.Apropie();

            var cardData = device.GetCardData();
            
            Console.WriteLine($"Plata in valoare de {sumaDePlata} efectuata cu succes cu cardul {cardData}");
            sumaDePlata = 0;
        }

        public void PlatesteContactfull(IContactfullPay device)
        {
            device.IntroduCard();
            
            var cardData = device.GetCardData();
            Console.WriteLine($"Plata in valoare de {sumaDePlata} efectuata cu succes cu cardul {cardData}");
            
            device.ExtrageCard();
            sumaDePlata = 0;
        }
    }
}