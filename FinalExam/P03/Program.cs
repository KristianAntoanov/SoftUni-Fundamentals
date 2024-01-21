namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guest = new Dictionary<string, List<string>>();


            string input = string.Empty;
            bool ifContains = true;
            int count = 0;
            List<string> meals = new List<string>();
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                ifContains = true;
                string currGuest = cmdArgs[1];
                string currMeal = cmdArgs[2];
                if (cmdArgs[0] == "Like")
                {
                    //Like-{guest}-{meal}
                    if (!guest.ContainsKey(currGuest))
                    {
                        guest[currGuest] = new List<string>();
                    }
                    meals = guest[currGuest];
                    if (!MealContains(meals, currMeal))
                    {
                        guest[currGuest].Add(currMeal);
                    }
                }
                else if (cmdArgs[0] == "Dislike")
                {
                    //Dislike-{guest}-{meal}
                    if (guest.ContainsKey(currGuest) && MealContains(meals, currMeal))
                    {
                        guest[currGuest].Remove(currMeal);
                        Console.WriteLine($"{currGuest} doesn't like the {currMeal}.");
                        count++;
                    }
                    else if (!guest.ContainsKey(currGuest))
                    {
                        Console.WriteLine($"{currGuest} is not at the party.");
                    }
                    else
                    {
                        Console.WriteLine($"{currGuest} doesn't have the {currMeal} in his/her collection.");
                    }
                }
            }
            foreach (var key in guest)
            {
                Console.Write($"{key.Key}: ");
                foreach (var item in key.Value)
                {
                    if (key.Value.IndexOf(item) == key.Value.Count - 1)
                    {
                        Console.Write($"{item}");
                    }
                    else
                    {
                        Console.Write($"{item}, ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
        static bool MealContains(List<string> meals, string currMeal)
        {
            return meals.Any(x => x == currMeal);
        }
    }
}