using System;
using System.Linq;

namespace _02_Diagonal_Difference
{
    class Diagonal_Difference
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix=new int[matrixSize,matrixSize];

            int sumPrimary = 0;
            int sumSecondary = 0;
            int currentRow = matrixSize-1;

            for (int i = 0; i < matrixSize; i++)
            {
                int[] arr = Console.ReadLine().Split(new char[]{' '}).Select(n => int.Parse(n))
                    .ToArray();

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = arr[j];
                    

                    if (i==j)
                    {
                        sumPrimary = sumPrimary + matrix[i, j];
                    }
                    if (i + j==matrixSize-1&&currentRow==j)
                    {
                        sumSecondary = sumSecondary + matrix[i, j];
                    }
                }

                currentRow = currentRow-1;
            }

            Console.WriteLine(Math.Abs(sumPrimary-sumSecondary));
        }
    }
}