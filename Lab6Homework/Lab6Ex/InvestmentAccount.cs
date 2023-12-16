using System;
using Lab6Ex.Properties;

namespace Lab6Ex
{
    public class InvestmentAccount : SavingsAccount
    {
        private int extractionDay;

        public InvestmentAccount(string name, Type type, double balanceValue, double interestRate, int extractionDay) : base(name, type, balanceValue, interestRate)
        {
            this.extractionDay = extractionDay;
            BalanceValue = balanceValue * (1 + InterestRate);
        }

        public override double Withdraw(double value)
        {
            if (extractionDay > DateTime.Now.Day)
            {
                Console.WriteLine($"Money can't be withdrew before {extractionDay} day");
                return BalanceValue;
            }

            return base.Withdraw(value);
        }

        public override string Description()
        {
            string description = base.Description();
            return $"{description}\nExpiration Day: {extractionDay}";
        }

    }
}