namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            long neededExperienceAmount = long.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());

            double allEcperience = 0;

            for (int i = 1; i <= countOfBattles; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    experiencePerBattle *= 1.15;
                }
                if (i % 5 == 0)
                {
                    experiencePerBattle *= 0.9;
                }
                if (i % 15 == 0)
                {
                    experiencePerBattle *= 1.05;
                }
                allEcperience += experiencePerBattle;
                if (allEcperience >= neededExperienceAmount)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {neededExperienceAmount - allEcperience:f2} more needed.");
        }
    }
}