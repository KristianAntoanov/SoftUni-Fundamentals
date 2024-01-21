namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                int currWagon = wagons[i];
                if (currWagon < 4)
                {
                    int emptySeats = 4 - currWagon;
                    people -= emptySeats;
                    if (people < 0)
                    {
                        wagons[i] = 4 + people;
                        Console.WriteLine($"The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", wagons));
                        return;
                    }
                    wagons[i] = 4;
                }
                
            }
            if (people != 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}