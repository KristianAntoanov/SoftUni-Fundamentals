namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            for (int i = 0; i < words.Length; i++)
            {
                Random random = new Random();

                int randomIndex = random.Next(0, words.Length);

                string currWord = words[i];
                string nextWord = words[randomIndex];

                words[i] = nextWord;
                words[randomIndex] = currWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}