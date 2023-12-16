using System;
using System.Globalization;

namespace Lab3Ex4
{
    class Program
    {
        /**
         * Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din sir sa inceapa cu MAJUSCULA,
         * restul literelor fiind transformate in litere mici
         * Exemplu:
         * Input: Ana ARE mErE
         * Rezultat: Ana Are Mere
         */
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetNormalisedString(input));
        }

        private static string GetNormalisedString(string input)
        {
            TextInfo text = new CultureInfo("en-US", false).TextInfo;
            return text.ToTitleCase(input.ToLowerInvariant());
        }
    }
}