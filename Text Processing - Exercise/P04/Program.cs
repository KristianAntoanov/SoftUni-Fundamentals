namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedString = string.Empty;

            foreach (char item in input)
            {
                int currPossition = item;
                currPossition += 3;

                encryptedString += (char)currPossition; 
            }
            Console.WriteLine(encryptedString);
        }
    }
}