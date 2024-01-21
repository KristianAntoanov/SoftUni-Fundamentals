namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))([a-zA-Z0-9]+[\.\-_]?)([A-Za-z])*@([A-Za-z]+)(\-)*?[A-Za-z]+(\.[a-zA-Z]+){1,}(\b|(?=\s))";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matchCollection = regex.Matches(input);
            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}