using System;
using System.Linq;

namespace _04_FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main()
        {
            int[] index = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string inputType = Console.ReadLine();

            Predicate<int> predicate = number => inputType == "even" ? number % 2 == 0 : number % 2 != 0;

            for (int i = index[0]; i <= index[1]; i++)
            {
                if (predicate(i))
                {
                    Console.Write($"{i} ");
                }
            }

            Console.WriteLine();
        }
    }
}