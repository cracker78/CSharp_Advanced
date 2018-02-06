using System;
using System.Linq;

namespace _02_KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            PrintNames(input);
        }

        private static void PrintNames(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Sir {input[i]}");
            }
        }
    }
}