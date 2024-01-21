namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Runtime.Intrinsics.X86;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                Random random1 = new Random();
                Random random2 = new Random();
                Random random3 = new Random();
                int randomPhrases = random.Next(0, phrases.Length);
                int randomEvents = random1.Next(0, events.Length);
                int randomAuthors = random2.Next(0, authors.Length);
                int randomCities = random3.Next(0, cities.Length);
                Console.WriteLine($"{phrases[randomPhrases]} {events[randomEvents]} {authors[randomAuthors]} – {cities[randomCities]}.");
            }
        }
    }
}