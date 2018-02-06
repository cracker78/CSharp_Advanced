using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculate_Sequence_with_Queue
{
    class CalculateSequenceQueue
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Queue<long> queue = new Queue<long>();

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{num} ");

                queue.Enqueue(num + 1);
                queue.Enqueue(2 * num + 1);
                queue.Enqueue(num + 2);

                num = queue.Dequeue();
            }


            Console.WriteLine();

        }
    }
}