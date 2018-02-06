using System;
using System.Collections.Generic;
using System.Text;

namespace _10_SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> oldVersions = new Stack<string>();

            StringBuilder text = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string command = tokens[0];

                if (command == "1")
                {
                    oldVersions.Push(text.ToString());
                    text.Append(tokens[1]);
                }
                else if (command == "2")
                {
                    oldVersions.Push(text.ToString());
                    int count = int.Parse(tokens[1]);
                    text = text.Remove(text.Length - count, count);
                }
                else if (command == "3")
                {
                    int index = int.Parse(tokens[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (command == "4")
                {
                    text = new StringBuilder(oldVersions.Pop());
                }
            }
        }
    }
}