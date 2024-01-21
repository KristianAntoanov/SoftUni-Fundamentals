namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Drawing;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            StringBuilder sb = new StringBuilder(activationKey);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = input
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Contains")
                {
                    string substring = cmdArgs[1];
                    if (sb.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{sb.ToString()} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (cmdArgs[0] == "Flip")
                {
                    //Flip>>>Upper/Lower>>>{startIndex}>>>{endIndex}
                    string UpOrLow = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endindex = int.Parse(cmdArgs[3]);

                    if (UpOrLow == "Upper")
                    {
                        for (int i = startIndex; i < endindex; i++)
                        {
                            char currchar = sb[i];
                            char modifiedChar = char.ToUpper(currchar);
                            sb[i] = modifiedChar;
                        }
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        for (int i = startIndex; i < endindex; i++)
                        {
                            char currchar = sb[i];
                            char modifiedChar = char.ToLower(currchar);
                            sb[i] = modifiedChar;
                        }
                        Console.WriteLine(sb.ToString());
                    }
                }
                else if (cmdArgs[0] == "Slice")
                {
                    //Slice>>>{startIndex}>>>{endIndex}
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    int length = endIndex - startIndex;
                    sb.Remove(startIndex, length);
                    Console.WriteLine(sb.ToString());
                }
            }
            Console.WriteLine($"Your activation key is: {sb.ToString()}");
        }
    }
}