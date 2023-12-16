namespace Lab6Ex.Properties
{
    public class SavingsAccount : BankAccount
    {
        protected double InterestRate { get; private set; }

        public SavingsAccount(string name, Type type, double balanceValue, double interestRate) : base(name, type, balanceValue)
        {
            InterestRate = interestRate;
            BalanceValue = balanceValue * (1 + InterestRate);
        }

        public override double Deposit(double value)
        {
            double newBalanceValue = value * (1 + InterestRate);
            BalanceValue += newBalanceValue;
            return BalanceValue;
        }

        public override double Withdraw(double value)
        {
            BalanceValue -= value;
            return BalanceValue;
        }

        public override string Description()
        {
            return $"Account ID: {Id}\nName: {Name}\nAccount type: {Type}\nBalance: {BalanceValue}\nInterest Rate: {InterestRate}";
        }
    }
}