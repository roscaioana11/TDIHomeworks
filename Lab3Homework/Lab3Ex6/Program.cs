using System;

namespace Lab3Ex6
{
    /**
     * Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m, respectiv m,n L ungimile celor doua
     * dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
     * Scrieti o functie care va calcula produsul celor doua matrici, apelati o si afisati rezultatul
     */
    class Program
    {
        private static readonly Random random = new Random();

        public static void Main(string[] args)
        {
            Console.Write("Read from the keyboard the length for \"n\": ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Read from the keyboard the length for \"m\": ");
            int m = int.Parse(Console.ReadLine());

            int[,] firstMatrix = GenerateMatrix(n, m, 0, 100);
            Console.WriteLine("First matrix: ");
            ShowMatrix(firstMatrix);
            
            int[,] secondMatrix = GenerateMatrix(m, n, 0, 100);
            Console.WriteLine("Second matrix: ");
            ShowMatrix(secondMatrix);

            int[,] multipliedMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
            Console.WriteLine("Multiplied matrix: ");
            ShowMatrix(multipliedMatrix);
        }
        
        private static int[,] GenerateMatrix(int rowLenght, int columnLenght, int minRandom, int maxRandom)
        {
            int[,] matrix = new int[rowLenght, columnLenght];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int randomNumber = random.Next(minRandom, maxRandom);
                    matrix[i, j] = randomNumber;
                }
            }
            return matrix;
        }

        private static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { 
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] MultiplyMatrix(int[,] fistMatrix, int[,] secondMatrix)
        {
            int rowFirstMatrix = fistMatrix.GetLength(0);
            int columnFirstMatrix = fistMatrix.GetLength(1);
            
            int rowSecondMatrix = secondMatrix.GetLength(0);
            int columnSecondMatrix = secondMatrix.GetLength(1);

            int[,] matrixResult = new int[rowFirstMatrix, columnSecondMatrix];

            if (columnFirstMatrix != rowSecondMatrix)
            {
                Console.WriteLine("Matrices can't be multiplied!");
                return new int[0, 0];
            }
            
            for (int i = 0; i < rowFirstMatrix; i++)
            {
                for (int j = 0; j < columnSecondMatrix; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < columnFirstMatrix; k++)
                    {
                        temp += fistMatrix[i, k] * secondMatrix[k, j];
                    }
                    matrixResult[i, j] = temp;
                }
            }

            return matrixResult;
        }
    }
}