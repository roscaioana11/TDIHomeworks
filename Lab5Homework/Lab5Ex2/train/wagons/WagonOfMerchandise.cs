namespace Lab5Ex2
{
    public class WagonOfMerchandise : Wagon
    {
        private MerchandiseType merchandiseType;
        private int capacity;

        public WagonOfMerchandise(int mass, int yearOfManufacture, MerchandiseType merchandiseType, int capacity) : base(mass, yearOfManufacture)
        {
            this.merchandiseType = merchandiseType;
            this.capacity = capacity;
        }
    }
}