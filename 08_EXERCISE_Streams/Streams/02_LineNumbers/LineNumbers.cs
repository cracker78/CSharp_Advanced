using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                int lineNumber = 1;

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.Write($"Line {lineNumber}: {line}");
                    writer.Write(Environment.NewLine);
                }
            }
        }
    }
}