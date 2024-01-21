namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = string.Empty;
            int turns = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                turns++;
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int index1 = int.Parse(cmdArgs[0]);
                int index2 = int.Parse(cmdArgs[1]);
                if (index1 < 0 || index1 > elements.Count - 1 || index2 < 0 || index2 > elements.Count - 1 || index1 == index2)
                {
                    elements.Insert(elements.Count / 2, $"-{turns}a");
                    elements.Insert(elements.Count / 2, $"-{turns}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (elements[index1] == elements[index2])
                {
                    string currElement = elements[index1];
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    elements.RemoveAt(index1);
                    if (index2 == 0)
                    {
                        index2 = 1;
                    }
                    elements.RemoveAt(index2 - 1);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {turns} turns!");
                    return;
                }

            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}