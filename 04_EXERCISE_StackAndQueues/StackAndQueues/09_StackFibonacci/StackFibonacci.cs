using System;
using System.Collections.Generic;

namespace _09_StackFibonacci
{
    class StackFibonacci
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            Stack<long> fibSeq = new Stack<long>();
            fibSeq.Push(1);
            fibSeq.Push(1);

            while (fibSeq.Count < number)
            {
                long lastFib = fibSeq.Pop();
                long currentFibNumber = lastFib + fibSeq.Peek();

                fibSeq.Push(lastFib);
                fibSeq.Push(currentFibNumber);
            }

            Console.WriteLine(fibSeq.Pop());
        }
    }
}

