using System;
using System.Collections.Generic;
using Lab8Ex.Exceptions;

namespace Lab8Ex
{
    public class BankAccount
    {
        private Guid id = Guid.NewGuid();
        private double totalAmount = 0;

        public Guid GetId() => id;

        public void DepositCash(double amount)
        {
            if (amount < 0)
            {
                throw new InvalidAmountException(amount);
            }
            totalAmount += amount;
            Console.WriteLine($"{amount} was added. Total amount: {totalAmount}");
        }

        public void WithdrawCash(double amount)
        {
            if (totalAmount - amount < 0)
            {
                throw new InsufficientFundsException();
            }
            totalAmount -= amount;
        }
    }
}