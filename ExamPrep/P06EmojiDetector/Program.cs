namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Numerics;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\d";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            long multiplayer = 1;
            int[] result = matchCollection
                .Select(x => int.Parse(x.Value))
                .ToArray();
            foreach (var item in result)
            {
                multiplayer *= item;
            }
            string pattern1 = @"(::|\*\*)[A-Z][a-z]{2,}\1";
            Regex regex1 = new Regex(pattern1);
            MatchCollection matchCollection1 = regex1.Matches(input);
            string[] result1 = matchCollection1
                .Select(x => x.Value)
                .ToArray();
            int asciiValues = 0;
            List<string> coolThreshold = new List<string>();
            foreach (var item in result1)
            {
                for (int i = 2; i < item.Length - 2; i++)
                {
                    asciiValues += (int)item[i];
                }
                if (asciiValues > multiplayer)
                {
                    coolThreshold.Add(item);
                }
                asciiValues = 0;
            }
            Console.WriteLine($"Cool threshold: {multiplayer}");
            Console.WriteLine($"{result1.Length} emojis found in the text. The cool ones are:");
            foreach (var item in coolThreshold)
            {
                Console.WriteLine(item);
            }
        }
    }
}