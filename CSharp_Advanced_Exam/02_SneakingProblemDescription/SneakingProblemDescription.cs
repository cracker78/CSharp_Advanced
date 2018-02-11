using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SneakingProblemDescription
{
    class SneakingProblemDescription
    {
        static void Main()
        {

            int rows = int.Parse(Console.ReadLine());

            char[][] arr = new char[][]{};

            int size = 0;

            for (int row = 0; row < rows-1; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                arr[row]=new char[currentRow.Length-1];

                for (int col = 0; col < currentRow.Length; col++)
                {
                    arr[row][col] = currentRow[col];
                }

                size = currentRow.Length;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
