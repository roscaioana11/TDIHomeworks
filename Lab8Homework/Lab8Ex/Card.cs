using System;

namespace Lab8Ex
{
    public class Card
    {
        private Guid id = Guid.NewGuid();

        public void EnterCard()
        {
            Console.WriteLine("Enter your card");
        }

        public Guid GetCardData()
        {
            return id;
        }

        public void ExtractCard()
        {
            Console.WriteLine("Extract your card");
        }
    }
}