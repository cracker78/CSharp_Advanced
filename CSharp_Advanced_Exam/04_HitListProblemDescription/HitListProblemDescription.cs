using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HitListProblemDescription
{
    class HitListProblemDescription
    {
        static void Main()
        {
            int infoIndex = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split(new char[] { '=', ':', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, SortedDictionary<string, string>> input = new Dictionary<string, SortedDictionary<string, string>>();

            while (!command[0].StartsWith("end"))
            {
                if (!input.ContainsKey(command[0]))
                {
                    input.Add(command[0], new SortedDictionary<string, string>());
                }

                if (input.ContainsKey(command[0]))
                {

                    for (int i = 1; i < command.Length - 1; i += 2)
                    {
                        if (input[command[0]].ContainsKey(command[i]))
                        {
                            input[command[0]].Remove(command[i]);
                            input[command[0]].Add(command[i], command[i + 1]);
                        }
                        else
                        {
                            input[command[0]].Add(command[i], command[i + 1]);
                        }

                    }
                }


                command = Console.ReadLine().Split(new char[] { '=', ':', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            string[] personName = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int currentInfoIndex = 0;

            foreach (var names in input)
            {
                if (names.Key.Contains(personName[1]))
                {
                    Console.WriteLine($"Info on {names.Key}:");
                    foreach (var profesion in names.Value)
                    {
                        Console.Write($"---{profesion.Key}: ");
                        Console.WriteLine(profesion.Value);
                        currentInfoIndex += profesion.Key.Length + profesion.Value.Length;
                    }
                }
            }

            if (currentInfoIndex >= infoIndex)
            {
                Console.WriteLine($"Info index: {currentInfoIndex}");
                Console.WriteLine($"Proceed");
            }
            else
            {
                Console.WriteLine($"Info index: {currentInfoIndex}");
                Console.WriteLine($"Need {Math.Abs(currentInfoIndex - infoIndex)} more info.");
            }
        }
    }
}
