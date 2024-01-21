namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(names);

            foreach (Match item in matchCollection)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}