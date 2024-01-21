namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input
                    .Split();
                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    wagons.Add(number);
                }
                else
                {
                    int number = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + number <= maxCapacity)
                        {
                            wagons[i] = wagons[i] + number;
                            break;
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}