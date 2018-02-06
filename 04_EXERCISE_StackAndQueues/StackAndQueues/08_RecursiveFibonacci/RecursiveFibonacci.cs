using System;

namespace _08_RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        private static long[] array;

        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            array = new long[number + 1];

            long fibonacci = CalculateFibonacci(number);
            Console.WriteLine(fibonacci);
        }

        private static long CalculateFibonacci(long number)
        {
            if (number <= 2)
            {
                return array[number] = 1;
            }

            if (array[number] != 0)
            {
                return array[number];
            }

            return array[number] =
                CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
        }
    }
}
