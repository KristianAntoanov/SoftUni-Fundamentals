﻿namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestList.Add(name);
                }
                else if (cmdArgs.Length == 4)
                {
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestList.Remove(name);
                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}