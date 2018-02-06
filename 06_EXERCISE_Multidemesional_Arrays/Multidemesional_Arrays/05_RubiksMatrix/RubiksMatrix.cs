using System;
using System.Linq;

namespace _05_RubiksMatrix
{
    class RubiksMatrix
    {
        static void Main(string[] args)
        {
            int[] rubikTokens = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int rowSize = rubikTokens[0];
            int colSize = rubikTokens[1];

            int[][] matrix = new int[rowSize][];

            int fillNumber = 1;
            for (int rowIndex = 0; rowIndex < rowSize; rowIndex++)
            {
                matrix[rowIndex] = new int[colSize];
                for (int colIndex = 0; colIndex < colSize; colIndex++)
                {
                    matrix[rowIndex][colIndex] = fillNumber;
                    fillNumber++;
                }
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandTokens = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                int index = int.Parse(commandTokens[0]);
                string direction = commandTokens[1];
                int moves = int.Parse(commandTokens[2]);

                switch (direction)
                {
                    case "up":
                        MoveCol(matrix, index, moves % rowSize);
                        break;
                    case "down":
                        MoveCol(matrix, index, rowSize - moves % rowSize);
                        break;
                    case "left":
                        MoveRow(matrix, index, moves % colSize);
                        break;
                    case "right":
                        MoveRow(matrix, index, colSize - moves % colSize);
                        break;
                }
            }

            fillNumber = 1;
            for (int rowIndex = 0; rowIndex < rowSize; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colSize; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == fillNumber)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        Swap(matrix, fillNumber, rowIndex, colIndex);
                    }

                    fillNumber++;
                }
            }
        }

        private static void Swap(int[][] matrix, int fillNumber, int row, int col)
        {
            bool hasSwapped = false;

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                for (int currCol = 0; currCol < matrix[0].Length; currCol++)
                {
                    if (matrix[currRow][currCol] == fillNumber)
                    {
                        int tempNumber = matrix[row][col];
                        matrix[row][col] = matrix[currRow][currCol];
                        matrix[currRow][currCol] = tempNumber;

                        Console.WriteLine($"Swap ({row}, {col}) with ({currRow}, {currCol})");
                        hasSwapped = true;
                        break;
                    }
                }

                if (hasSwapped)
                {
                    return;
                }
            }
        }

        private static void MoveRow(int[][] matrix, int rowIndex, int moves)
        {
            int colSize = matrix[0].Length;
            int[] temp = new int[colSize];

            for (int colIndex = 0; colIndex < colSize; colIndex++)
            {
                int nextColIndex = (moves + colIndex) % colSize;
                temp[colIndex] = matrix[rowIndex][nextColIndex];
            }

            for (int colIndex = 0; colIndex < colSize; colIndex++)
            {
                matrix[rowIndex][colIndex] = temp[colIndex];
            }
        }

        private static void MoveCol(int[][] matrix, int colIndex, int moves)
        {
            int[] temp = new int[matrix.Length];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                temp[rowIndex] = matrix[(rowIndex + moves) % matrix.Length][colIndex];
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex][colIndex] = temp[rowIndex];
            }
        }
    }
}