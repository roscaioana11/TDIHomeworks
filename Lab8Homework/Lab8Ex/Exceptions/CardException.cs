using System;

namespace Lab8Ex.Exceptions
{
    public class CardException: Exception
    {
        private const string CardDoesNotExists = "Card does not exists.";
        
        public CardException() : base(CardDoesNotExists)
        {
            
        }
    }
}