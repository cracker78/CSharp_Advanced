using System;
using System.Linq;

namespace _01_Matrix_Of_Palindromes
{
    class Matrix_Of_Palindromes
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(n=>int.Parse(n))
                .ToArray();

            int rows = input[0];
            int cols = input[0];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{alphabet[i].ToString() + alphabet[i+j].ToString() + alphabet[i].ToString() + " "}");
                }

                Console.WriteLine();
            }
        }
    }
}