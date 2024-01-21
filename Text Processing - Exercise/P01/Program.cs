namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < usernames.Count; i++)
            {
                string currUser = usernames[i];
                if (currUser.Length > 3 && currUser.Length <= 16)
                {
                    bool isValid = true;
                    for (int i2 = 0; i2 < currUser.Length; i2++)
                    {
                        char currChar = currUser[i2];
                        if (!(currChar == '-' || currChar == '_' || char.IsLetterOrDigit(currChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(currUser);
                    }
                }
            }
        }
    }
}