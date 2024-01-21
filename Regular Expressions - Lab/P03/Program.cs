namespace MyApp // Note: actual namespace depends on the project name.
{
    using System; 
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match item in matchCollection)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }
        }
    }
}