using System;

namespace Lab8Ex.Exceptions
{
    public class BankAccountException: Exception
    {
        private const string AccountDoesNotExists = "Account does not exists.";
        
        private const string AccountCantHoldMoreThanTwoCard =
            "Account with ID: {1} already has 2 card";

        private const string CardAlreadyExistsInThisAccount =
            "Card with ID: {0}, already exists in Account with ID: {1}";

        public BankAccountException() : base(AccountDoesNotExists)
        {
            
        }

        public BankAccountException(Guid accountId) : base(string.Format(AccountCantHoldMoreThanTwoCard, accountId))
        {
            
        }
        
        public BankAccountException(Guid cardId, Guid accountId) : base(string.Format(CardAlreadyExistsInThisAccount, cardId, accountId))
        {
            
        }
    }
}