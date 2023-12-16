namespace Lab4Ex2
{
    public class Car
    {
        private string brand;
        private string licensePlate;
        private int cylindricalCapacity;

        public Car(string brand, string licensePlate, int cylindricalCapacity)
        {
            this.brand = brand;
            this.licensePlate = licensePlate;
            this.cylindricalCapacity = cylindricalCapacity;
        }

        public string GetDescription()
        {
            return $"Brand: {brand}, License Plate: {licensePlate}, Cylindrical Capacity: {cylindricalCapacity}";
        }
    }
}