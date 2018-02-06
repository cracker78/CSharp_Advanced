using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Maximum_Element
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < numOfOperations; i++)
            {
                int[] num = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n)).ToArray();

                int opperation = num[0];

                switch (opperation)
                {
                    case 1: stack.Push(num[1]);
                        break;
                    case 2: stack.Pop();
                        break;
                    case 3: Console.WriteLine(stack.Max());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}