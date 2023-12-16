using System;

namespace Lab8Ex.Exceptions
{
    public class InvalidAmountException:Exception
    {
        private const string InvalidAmount = "Invalid Amount {0}";

        public InvalidAmountException(double amount) : base(string.Format(InvalidAmount, amount))
        {
            
        }
    }
}