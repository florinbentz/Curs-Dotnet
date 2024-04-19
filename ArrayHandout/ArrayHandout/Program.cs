using System.ComponentModel;

namespace ArrayHandout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Write a program for a 2D array of size 3x3 and print the matrix.
            int[,] matrix = new int[3, 3];
            //ReadMatrixFromConsole(matrix);
            GenerateAnIntMatrix(matrix);
            PrintMatrix(matrix);

            //Exercise 2
            //Write a program in C# Sharp for addition of two Matrices of same size

            Console.Write("Introduceti numarul de linii al matricii: ");
            int numberOfLines = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            Console.Write("Introduceti numarul de coloane al matricii: ");
            int numberOfColumns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrix1 = new int[numberOfLines, numberOfColumns];
            GenerateAnIntMatrix(matrix1);
            PrintMatrix(matrix1);

            int[,] matrix2 = new int[numberOfLines, numberOfColumns];
            GenerateAnIntMatrix(matrix2);
            PrintMatrix(matrix2);

            int[,] result = new int[numberOfLines, numberOfColumns];
            result = GetMatrixSum(matrix1, matrix2);
            Console.WriteLine("Matricea suma:");
            PrintMatrix(result);

            //Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes

        }

        static int[,] ReadMatrixFromConsole(int[,] matrix)
        {
            Console.WriteLine("Intorduceti elementele matricii numere intregi urmate de Enter!");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Elementul A({i + 1},{j + 1}) = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        static int[,] GenerateAnIntMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("Elementele matricii sunt urmatoarele:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] GetMatrixSum(int[,] matrix1, int[,] matrix2)
        {
            int n = matrix1.GetLength(0);
            int m = matrix1.GetLength(1);
            int[,] result = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }



    }
}
