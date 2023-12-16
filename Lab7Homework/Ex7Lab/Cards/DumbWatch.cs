using System;
using Ex7Lab.POS;

namespace Ex7Lab.Cards
{
    public class DumbWatch: IContactlessPay
    {
        private SmartPhone phone;
        public void AddPhone(SmartPhone phone)
        {
            this.phone = phone;
        }
        public void Apropie()
        {
            Console.WriteLine("Apripe DumbWatch-ul");
        }

        public string GetCardData()
        {
            if (phone != null)
            {
                return phone.GetCardData();
            }
            return string.Empty;
        }
    }
}