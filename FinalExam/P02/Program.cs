namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Drawing;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"[@#]+([a-z]{3,})[@#]+[^a-z0-9]*[\/]+(\d+)[\/]+";

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(text);

            foreach (Match item in matchCollection)
            {
                Console.WriteLine($"You found {item.Groups[2].Value} {item.Groups[1].Value} eggs!");
            }
            if (matchCollection.Count < 1)
            {
                Console.WriteLine($"You found {0} {0} eggs!");
            }

        }
    }
}