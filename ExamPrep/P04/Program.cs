namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = commands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[0] == "TakeOdd")
                {
                    for (int i = sb.Length - 1; i >= 0; i--)
                    {
                        if (i % 2 == 0)
                        {
                            sb.Remove(i, 1);
                        }
                    }
                    Console.WriteLine(sb.ToString());
                }
                else if (cmdArgs[0] == "Cut")
                {
                    //Cut {index} {length}
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);
                    sb.Remove(index, length);
                    Console.WriteLine(sb.ToString());
                }
                else if (cmdArgs[0] == "Substitute")
                {
                    //Substitute {substring} {substitute}
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];
                    if (sb.ToString().Contains(substring))
                    {
                        sb.Replace(substring, substitute);
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {sb.ToString()}");
        }
    }
}