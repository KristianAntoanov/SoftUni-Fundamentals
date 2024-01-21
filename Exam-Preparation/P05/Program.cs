namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = string.Empty;
            int count = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int indexToShoot = int.Parse(command);
                if (indexToShoot < 0 || indexToShoot > numbers.Length - 1)
                {
                    continue;
                }

                if (indexToShoot == -1)
                {
                    continue;
                }
                count++;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == indexToShoot)
                    {
                        continue;
                    }
                    if (numbers[i] <= numbers[indexToShoot] && numbers[i] != -1)
                    {
                        numbers[i] = numbers[i] + numbers[indexToShoot];
                    }
                    else if (numbers[i] > numbers[indexToShoot] && numbers[i] != -1)
                    {
                        numbers[i] = numbers[i] - numbers[indexToShoot];
                    }
                }
                numbers[indexToShoot] = -1;
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", numbers)}");
        }
    }
}