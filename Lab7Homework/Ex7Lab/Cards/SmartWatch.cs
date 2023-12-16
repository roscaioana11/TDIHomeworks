using System;
using Ex7Lab.POS;

namespace Ex7Lab.Cards
{
    public class SmartWatch:IContactlessPay
    {
        private Guid cardData = Guid.NewGuid();
        public void Apropie()
        {
            Console.WriteLine("Apropiem SmartWatch-ul");
        }

        public string GetCardData()
        {
            return cardData.ToString();
        }
    }
}