using System;
using Ex7Lab.POS;

namespace Ex7Lab.Cards
{
    public class SmartPhone:IContactlessPay
    {
        private Guid phoneId = Guid.NewGuid();
        public void Apropie()
        {
            Console.WriteLine("Apropiem Smartfone-ul");
        }

        public string GetCardData()
        {
            return $"phone id: {phoneId}";
        }
    }
}