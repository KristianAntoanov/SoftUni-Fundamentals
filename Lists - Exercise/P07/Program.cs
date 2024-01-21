namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<int> numbers = new List<int>();

            foreach (var item in arrays)
            {
                numbers.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}