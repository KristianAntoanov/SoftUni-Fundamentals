namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                char currChar = word[i];

                if (currChar == ' ')
                {
                    continue;
                }
                if (!countOfChars.ContainsKey(currChar))
                {
                    countOfChars.Add(currChar, 0);
                }
                countOfChars[currChar] += 1;
            }
            foreach (var item in countOfChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}