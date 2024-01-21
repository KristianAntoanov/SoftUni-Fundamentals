namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\|\$\%\.]*?\%(?<customer>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$[^\|\$\%\.]*?$";

            Regex regex = new Regex(pattern);
            double totalIncome = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    totalIncome += count * price;
                    Console.WriteLine($"{match.Groups["customer"].Value}: {match.Groups["product"].Value} - {count * price:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}