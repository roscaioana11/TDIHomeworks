using Lab8Ex.Exceptions;

namespace Lab8Ex
{
    public class Pos
    {
        private Bank bank;
        public Pos(Bank bank)
        {
            this.bank = bank;
        }

        public void Pay(double amount, Card card)
        {
            try
            {
                card.EnterCard();
                card.GetCardData().ToString();

                bank.Pay(2000.0, card.GetCardData());
            }
            catch(InsufficientFundsException e)
            {
                throw new InsufficientFundsException();
            }
            finally
            {
                card.ExtractCard();
            }
        }

        public void Connect()
        {
            try
            {
                bank.Connect();
            }
            catch (BankExceptions e)
            {
                throw new BankExceptions();
            }
        }
    }
}