using System;
using System.Linq;

namespace _03_CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            min = MinNumber(min, input);
        }

        private static int MinNumber(int min, int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                }
            }

            Console.WriteLine(min);
            return min;
        }
    }
}