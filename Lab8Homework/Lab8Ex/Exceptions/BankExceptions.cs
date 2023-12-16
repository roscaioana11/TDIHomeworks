using System;

namespace Lab8Ex.Exceptions
{
    public class BankExceptions: Exception
    {
        private const string ExceededNumberOfConnections = "Exceeded the maximum number of connection. Maximum is 3";
        
        public BankExceptions() : base(ExceededNumberOfConnections)
        {
            
        }
    }
}