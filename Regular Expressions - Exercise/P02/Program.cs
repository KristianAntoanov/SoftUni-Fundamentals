namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern1 = @"(?<name>[A-Za-z])";
            string pattern2 = @"\d";
            List<string> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Regex regex1 = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);

            Dictionary<string, int> bestPlayers = new Dictionary<string, int>();

            foreach (var item in names)
            {
                bestPlayers[item] = 0;
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection matchName = regex1.Matches(input);
                MatchCollection matchNumbers = regex2.Matches(input);
                string currName = string.Join("", matchName);
                int currNumbers = matchNumbers.Sum(x => int.Parse(x.Value));

                if (bestPlayers.ContainsKey(currName))
                {
                    bestPlayers[currName] += currNumbers;
                }
            }
            Dictionary<string, int> topThree = bestPlayers.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);
            int count = 1;
            foreach (var item in topThree)
            {
                if (count == 1)
                {
                    Console.WriteLine($"{count}st place: {item.Key}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"{count}nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"{count}rd place: {item.Key}");
                }
                count++;
            }
        }
    }
}
