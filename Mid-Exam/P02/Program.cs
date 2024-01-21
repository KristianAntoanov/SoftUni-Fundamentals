namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int countBlacklisted = 0;
            int countOfLost = 0;
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Report")
            {
                string[] cmdArgs = commands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (cmdArgs[0] == "Blacklist")
                {
                    string name = cmdArgs[1];
                    int index = -1;

                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            index = i;
                            break;
                        }
                    }

                    if (index != -1)
                    {
                        names[index] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                        countBlacklisted++;
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (cmdArgs[0] == "Error")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index > names.Length - 1)
                    {
                        continue;
                    }
                    if (names[index] == "Blacklisted" || names[index] == "Lost")
                    {
                        continue;
                    }
                    countOfLost++;
                    Console.WriteLine($"{names[index]} was lost due to an error.");
                    names[index] = "Lost";
                }
                else if (cmdArgs[0] == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string newName = cmdArgs[2];
                    if (index < 0 || index > names.Length - 1)
                    {
                        continue;
                    }
                    Console.WriteLine($"{names[index]} changed his username to {newName}.");
                    names[index] = newName;
                }
            }
            Console.WriteLine($"Blacklisted names: {countBlacklisted}");
            Console.WriteLine($"Lost names: {countOfLost}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}