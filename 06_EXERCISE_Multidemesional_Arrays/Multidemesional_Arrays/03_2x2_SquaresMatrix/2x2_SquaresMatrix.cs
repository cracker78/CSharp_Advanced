using System;
using System.Linq;

namespace _03_2x2_SquaresMatrix
{
    class SquaresMatrix
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix=new string[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                string[] row = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int index = 0;

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[index];
                    index++;
                }
            }
            int count = 0;

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    if (matrix[i,j]==matrix[i,j+1]&&matrix[i+1,j]==matrix[i+1,j+1]&&matrix[i,j]==matrix[i+1,j+1])
                    {
                        count++;
                    }
                    
                }
            }

            Console.WriteLine(count);
        }
    }
}