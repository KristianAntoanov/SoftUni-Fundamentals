namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfInput = int.Parse(Console.ReadLine());

            string pattern = @"^@#{1,}(?<letters>[A-Z][a-z0-9A-Z]{4,}[A-Z])@#*$";
            string patternForNumbers = @"[0-9]{1,}";

            Regex regex = new Regex(pattern);


            for (int i = 0; i < numOfInput; i++)
            {
                string barcode = Console.ReadLine();

                Match match = regex.Match(barcode);
                if (match.Success)
                {
                    Regex regex1 = new Regex(patternForNumbers);
                    MatchCollection matchCollection = regex1.Matches(barcode);
                    if (matchCollection.Count != 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", matchCollection)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {0:D2}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}