using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6Ex
{
    public abstract class BankAccount
    {
        private Guid id = Guid.NewGuid();
        protected string Name { get; private set; }
        protected Type Type { get; private set; }
        protected double BalanceValue{ get; set; }
        private static int numberOfAccounts = 0;

        protected BankAccount(string name, Type type, double balanceValue)
        {
            Name = name;
            Type = type;
            BalanceValue = balanceValue;
            numberOfAccounts++;
        }

        protected Guid Id
        {
            get { return id; }
        }

        public abstract double Deposit(double value);
        
        public abstract double Withdraw(double value);

        public abstract string Description();

        public static int GetNumberOfAccounts()
        {
            if (numberOfAccounts == 0)
            {
                Console.WriteLine("No Bank Account created!");
                return numberOfAccounts;
            }

            return numberOfAccounts;
        }
    }
}