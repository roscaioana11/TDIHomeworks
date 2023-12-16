using System;

namespace Lab8Ex.Exceptions
{
    public class InsufficientFundsException:Exception
    {
        private const string InsufficientFundsConst = "Insufficient funds.";

        public InsufficientFundsException() : base(InsufficientFundsConst)
        {
            
        }
    }
}