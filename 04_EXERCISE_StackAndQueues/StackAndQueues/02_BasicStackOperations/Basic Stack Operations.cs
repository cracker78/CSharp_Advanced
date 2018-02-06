using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Basic_Stack_Operations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split(new char[] {' '}).Select(n => int.Parse(n)).ToArray();

            int numberOfElements = operations[0];
            int popElements = operations[1];
            int serchNumber = operations[2];

            var stack = new Stack<int>();

            int[] arr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            for (int i=0; i< popElements; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(serchNumber))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}