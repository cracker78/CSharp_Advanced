using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Stack<char> brackets = new Stack<char>();

            bool isBalanced = true;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(' || line[i] == '{' || line[i] == '[')
                    brackets.Push(line[i]);
                else if (line[i] == ')')
                    isBalanced = IsBalanced(brackets, isBalanced, '(');
                else if (line[i] == ']')
                    isBalanced = IsBalanced(brackets, isBalanced, '[');
                else if (line[i] == '}')
                    isBalanced = IsBalanced(brackets, isBalanced, '{');

                if (!isBalanced)
                    break;
            }

            if (isBalanced)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        private static bool IsBalanced(Stack<char> brackets, bool flag, char ch)
        {
            if (!brackets.Any())
            {
                flag = false;
            }
            else if (brackets.Pop() != ch)
            {
                flag = false;
            }

            return flag;
        }
    }
}