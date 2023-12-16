using System;

namespace Lab4Ex1
{
    class Program
    {
        /**
         * Un dulap are trei caracteristici: lungime, latime, inaltime. Dulapul va avea o metoda care va calcula volumul acestuia.
         * Folositi o clasa care va modela un dulap.
         * - Clasa va avea trei campuri private intregi: lungime, latime, inaltime
         * - Cele trei campuri vor fi initializate cu ajutorul constructorului
         * - Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri
         * Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si afisati rezultatul
         */
        public static void Main(string[] args)
        {
            Wardrobe wardrobe = new Wardrobe(3, 2, 4);

            Console.Write($"Wardrobe volume = {wardrobe.GetVolume()}");
        }
    }
}