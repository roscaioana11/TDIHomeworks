namespace Lab4Ex3
{
    public class Passenger
    {
        private string lastName;
        private string firstName;

        public Passenger(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName}";
        }
    }
}