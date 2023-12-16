using System;
using Ex7Lab.POS;

namespace Ex7Lab.Cards
{
    public class ClassicCard:IContactfullPay
    {
        private Guid cardData = Guid.NewGuid();
        public void IntroduCard()
        {
            Console.WriteLine("Extragem cardul");
        }

        public string GetCardData()
        {
            return cardData.ToString();
        }

        public void ExtrageCard()
        {
            Console.WriteLine("Introducem cardul");
        }
    }
}