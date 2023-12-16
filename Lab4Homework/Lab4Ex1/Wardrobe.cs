namespace Lab4Ex1
{
    public class Wardrobe
    {
        private int wLenght;
        private int width;
        private int height;

        public Wardrobe(int wLenght, int width, int height)
        {
            this.wLenght = wLenght;
            this.width = width;
            this.height = height;
        }

        public int GetVolume()
        {
            return wLenght * width * height;
        }
    }
}