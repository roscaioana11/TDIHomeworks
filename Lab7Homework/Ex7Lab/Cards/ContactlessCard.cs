using System;
using Ex7Lab.POS;

namespace Ex7Lab.Cards
{
    public class ContactlessCard:ClassicCard, IContactlessPay
    {
        public void Apropie()
        {
            Console.WriteLine("Cardul a fost apropiat");
        }
    }
}