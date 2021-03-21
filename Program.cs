using System;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = " ";
            string pattern = @"([A-Z][a-z]+): (\d+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);

            Console.WriteLine(match.Groups.Count); // 3
            Console.WriteLine("Matched text: \"{0}\"", match.Groups[0]);
            Console.WriteLine("Name: {0}", match.Groups[1]); // Nakov
            Console.WriteLine("Number: {0}", match.Groups[2]); // 123

        }
    }
}
