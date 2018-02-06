using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_TargetPractice
{
    class TargetPractice
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = size[0];
            int col = size[1];

            char[] stringInput = Console.ReadLine().ToCharArray();

            int[] splash= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowSplash = splash[0];
            int colSplash = splash[1];
            int bombRadius = splash[2];

            Queue<char> symbols=new Queue<char>();
            int k = 0;

            for (int i = 0; i < row*col; i++)
            {
                symbols.Enqueue(stringInput[k]);
                k++;
                if (k>stringInput.Length-1)
                {
                    k = 0;
                }
            }

            char[,] matrix=new char[row,col];

            int cnt = 0;
            int current = 0;

            for (int i = row-1; i >= 0; i--)
            {
                if ((row+cnt)%2==row%2)
                {
                    for (int j = col-1; j >= 0; j--)
                    {

                        matrix[i, j] = symbols.Dequeue();
                    }

                }
                else
                {
                    for (int j = 0; j <= col-1; j++)
                    {

                        matrix[i, j] = symbols.Dequeue();
                    }
                }

                cnt++;
            }

            if (bombRadius>0)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (i>(rowSplash-2)&&i<rowSplash+2)
                        {
                            
                        }
                        matrix[i, j] = '*';
                    }
                    
                }
            }

        }
    }
}