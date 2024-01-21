namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var item in words)
            {
                string currItem = item.ToLower();
                if (!wordCount.ContainsKey(currItem))
                {
                    wordCount.Add(currItem, 0);
                }
                wordCount[currItem] += 1;
            }
            foreach (var item in wordCount)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}