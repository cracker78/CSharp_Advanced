using System;
using System.Collections.Generic;
using System.Linq;

namespace _06
{
    class TruckTour
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<Tuple<int, int, int>> pumps = new Queue<Tuple<int, int, int>>();

            for (int i = 0; i < n; i++)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int fuel = tokens[0];
                int distance = tokens[1];

                Tuple<int, int, int> pump = new Tuple<int, int, int>(fuel, distance, i);
                pumps.Enqueue(pump);
            }

            Queue<Tuple<int, int, int>> dequeuedPumps = new Queue<Tuple<int, int, int>>();
            while (true)
            {
                Tuple<int, int, int> currentPump = pumps.Dequeue();
                dequeuedPumps.Enqueue(currentPump);

                int fuel = currentPump.Item1;
                int distance = currentPump.Item2;

                while (true)
                {
                    if (pumps.Count == 0 || distance > fuel)
                        break;

                    fuel -= distance;

                    Tuple<int, int, int> nextPump = pumps.Dequeue();
                    fuel += nextPump.Item1;
                    distance = nextPump.Item2;

                    dequeuedPumps.Enqueue(nextPump);
                }

                if (fuel >= 0 && pumps.Count == 0)
                {
                    Console.WriteLine(currentPump.Item3);
                    break;
                }

                while (dequeuedPumps.Count > 0)
                {
                    pumps.Enqueue(dequeuedPumps.Dequeue());
                }
            }
        }
    }
}