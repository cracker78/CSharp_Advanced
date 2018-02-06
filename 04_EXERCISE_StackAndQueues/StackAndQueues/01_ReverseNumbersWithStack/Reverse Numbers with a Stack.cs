using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueues
{
    class ReverseNumbersWithStack
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToList();
            var stack = new Stack<int>();

            foreach (var num in numbers)
            {
                stack.Push(num);
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}