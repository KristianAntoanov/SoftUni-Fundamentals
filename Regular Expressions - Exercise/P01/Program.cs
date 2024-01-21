namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+(\.\d+)?)$";

            Regex regex = new Regex(pattern);
            List<string> names = new List<string>();

            double totalSpendMoney = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    totalSpendMoney += price * (int)quantity;
                    names.Add(match.Groups["name"].Value);

                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalSpendMoney:f2}");
        }
    }
}