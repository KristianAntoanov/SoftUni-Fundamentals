namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Data;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (cmdType == "Insert")
                {
                    int number1 = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number1);
                }
                else if (cmdType == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (cmdType == "Shift")
                {
                    string leftOrRight = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);
                    if (leftOrRight == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else if (leftOrRight == "right")
                    {
                        ShiftListRight(numbers, count); 
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }
        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }
    }
}