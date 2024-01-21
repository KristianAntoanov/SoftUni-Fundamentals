namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    int winingCard = firstPlayer[0];
                    int loosingcard = secondPlayer[0];
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.Add(loosingcard);
                    firstPlayer.Add(winingCard);
                }
                else if (secondPlayer[0] > firstPlayer[0])
                {
                    int winingCard = secondPlayer[0];
                    int loosingcard = firstPlayer[0];
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    secondPlayer.Add(loosingcard);
                    secondPlayer.Add(winingCard);
                }
                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }
            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}