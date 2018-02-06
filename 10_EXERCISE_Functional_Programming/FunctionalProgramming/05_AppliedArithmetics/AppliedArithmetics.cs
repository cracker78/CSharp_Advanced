using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command) {
                    case "add": input.Select(n => n + 1);
                        break;
                    case "multiply": input.Select(n => n * 2).ToList();
                        break;
                    case "subtract": input.Select(n => n - 1).ToList();
                        break;
                    case "print":
                        foreach (var num in input)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}