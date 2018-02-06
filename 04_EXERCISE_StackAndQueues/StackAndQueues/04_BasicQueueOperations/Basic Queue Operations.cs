using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split(new char[] { ' ' }).Select(n => int.Parse(n)).ToArray();

            int numberOfElements = operations[0];
            int popElements = operations[1];
            int serchNumber = operations[2];

            Queue<int> queue = new Queue<int>();

            int smallestElement = int.MaxValue;

            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < numberOfElements; i++)
            {
                queue.Enqueue(arr[i]);
            }

            for (int i = 0; i < popElements; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(serchNumber))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                foreach (var min in queue)
                {
                    if (smallestElement>min)
                    {
                        smallestElement = min;
                    }
                }

                Console.WriteLine(smallestElement);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}