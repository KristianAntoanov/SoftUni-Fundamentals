namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int result = GetVowelsCount(word);
            Console.WriteLine(result);
        }
        static int GetVowelsCount (string word)
        {
            int counter = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
            foreach (char letter in word.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}