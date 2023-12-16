using System;
using System.Collections.Generic;
using Lab8Ex.Exceptions;

namespace Lab8Ex
{
    public class Bank
    {
        private Dictionary<Guid, BankAccount> bankAccounts = new Dictionary<Guid, BankAccount>();
        private Dictionary<Guid, BankAccount> accountsDictionary = new Dictionary<Guid, BankAccount>();
        private Dictionary<Guid, int> cardsPerAccount = new Dictionary<Guid, int>();
        private static int numberOfActiveConnections = 0;

        public Dictionary<Guid, BankAccount> GetBankAccounts() => bankAccounts;

        public Guid CreateAccount()
        {
            BankAccount bankAccount = new BankAccount();

            bankAccounts.Add(bankAccount.GetId(), bankAccount);

            return bankAccount.GetId();
        }

        public void IssueCard(Guid bankAccountId)
        {
            if (!bankAccounts.ContainsKey(bankAccountId))
            {
                throw new BankAccountException();
            }

            if (bankAccounts[bankAccountId].GetNumberOfCardForBankAccount() > 2)
            {
                throw new BankAccountException(bankAccountId);
            }

            Card card = new Card();

            bankAccounts[card.GetCardData()] = b;
        }

        public void Pay(double amount, Guid cardId)
        {
            if (!bankAccounts.ContainsKey(cardId))
            {
                throw new BankAccountException();
            }
            
            // throw exception for card
            
            bankAccounts[cardId].WithdrawCash(amount);
        }

        public void Connect()
        {
            if (numberOfActiveConnections > 3)
            {
                throw new BankExceptions();
            }
             
            numberOfActiveConnections++;
            Console.WriteLine("Connected");
        }

        public void Disconnect()
        {
            numberOfActiveConnections--;
            if (numberOfActiveConnections < 0)
            {
                numberOfActiveConnections = 0;
            }
            Console.WriteLine("Disconnected");
        }
    }
}