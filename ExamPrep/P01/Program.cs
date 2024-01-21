namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder(message);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArg = input
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (cmdArg[0] == "InsertSpace")
                {
                    int index = int.Parse(cmdArg[1]);
                    sb.Insert(index, " ");
                    Console.WriteLine(sb.ToString());
                }
                else if (cmdArg[0] == "Reverse")
                {
                    string messageForCut = cmdArg[1];
                    if (sb.ToString().Contains(messageForCut))
                    {
                        sb.Replace(messageForCut, "");
                        char[] chars = messageForCut.ToCharArray();
                        Array.Reverse(chars);
                        string reversedString = new string(chars);
                        sb.Append(reversedString);
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdArg[0] == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replacement = cmdArg[2];

                    sb.Replace(substring, replacement);
                    Console.WriteLine(sb.ToString());
                }
            }
            string result = sb.ToString();
            Console.WriteLine($"You have a new text message: {result}");
        }
    }
}