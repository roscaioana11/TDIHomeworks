using System;

namespace Lab6Ex
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string name, Type type, double balanceValue) : base(name, type, balanceValue)
        {
        }

        public override double Deposit(double value)
        {
            BalanceValue += value;
            return BalanceValue;
        }

        public override double Withdraw(double value)
        {
            if (BalanceValue - value < -5000)
            {
                Console.WriteLine($"Your current balance is {BalanceValue}.\nCan't withdraw {value}, it will exceeds -5000");
                return BalanceValue;
            }
            
            BalanceValue -= value;
            return BalanceValue;
        }

        public override string Description()
        {
            return $"Account ID: {Id}\nName: {Name}\nAccount type: {Type}\nBalance: {BalanceValue}";
        }
    }
}
