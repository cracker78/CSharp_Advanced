using System;
using System.Linq;

namespace _04_MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int rows = tokens[0];
            int cols = tokens[1];

            int[][] matrix = new int[rows][];
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                int[] col = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[rowIndex] = col;
            }

            int maxRow = 0;
            int maxCol = 0;
            int maxSum = int.MinValue;

            for (int rowIndex = 0; rowIndex < rows - 2; rowIndex++)
            {
                for (int colIndex = 0; colIndex < cols - 2; colIndex++)
                {
                    int sum = matrix[rowIndex][colIndex] +
                              matrix[rowIndex][colIndex + 1] +
                              matrix[rowIndex][colIndex + 2] +
                              matrix[rowIndex + 1][colIndex] +
                              matrix[rowIndex + 1][colIndex + 1] +
                              matrix[rowIndex + 1][colIndex + 2] +
                              matrix[rowIndex + 2][colIndex] +
                              matrix[rowIndex + 2][colIndex + 1] +
                              matrix[rowIndex + 2][colIndex + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = rowIndex;
                        maxCol = colIndex;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol + 1]} {matrix[maxRow][maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1][maxCol]} {matrix[maxRow + 1][maxCol + 1]} {matrix[maxRow + 1][maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2][maxCol]} {matrix[maxRow + 2][maxCol + 1]} {matrix[maxRow + 2][maxCol + 2]}");
        }
    }
}