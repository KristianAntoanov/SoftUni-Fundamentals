namespace P02
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"\+359(-| )2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            string[] result = matchCollection
                .Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}