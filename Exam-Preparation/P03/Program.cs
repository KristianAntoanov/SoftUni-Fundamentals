namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (cmdArgs[0] == "Shoot")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int power = int.Parse(cmdArgs[2]);
                    if (index < 0 || index > numbers.Count - 1)
                    {
                        continue;
                    }
                    numbers[index] -= power;
                    if (numbers[index] <= 0)
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (cmdArgs[0] == "Add")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);
                    if (index < 0 || index > numbers.Count - 1)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    numbers.Insert(index, value);
                }
                else if (cmdArgs[0] == "Strike")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int radius = int.Parse(cmdArgs[2]);
                    int rangeFrom = index - radius;
                    int rangeTo = index + radius;
                    if (rangeFrom < 0 || rangeTo > numbers.Count - 1 || rangeFrom > rangeTo)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    for (int i = rangeFrom; i <= rangeTo; i++)
                    {
                        numbers.RemoveAt(rangeFrom);
                    }
                }
            }
            Console.WriteLine(string.Join("|", numbers));
        }
    }
}