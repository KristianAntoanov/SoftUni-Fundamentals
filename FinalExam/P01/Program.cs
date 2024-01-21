namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {

            string password = Console.ReadLine();

            bool lettersDigits = true;
            bool isOneUpper = false;
            bool isOnelower = false;
            int counterDigits = 0;

            StringBuilder sb = new StringBuilder(password);
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[0] == "Make")
                {
                    //Make Upper {index}
                    int index = int.Parse(cmdArgs[2]);
                    if (cmdArgs[1] == "Upper")
                    {
                        char charToReplace = sb[index];
                        char upperCaseChar = char.ToUpper(charToReplace);
                        sb[index] = upperCaseChar;
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        char charToReplace = sb[index];
                        char upperCaseChar = char.ToLower(charToReplace);
                        sb[index] = upperCaseChar;
                        Console.WriteLine(sb.ToString());
                    }
                }
                else if (cmdArgs[0] == "Insert")
                {
                    //Insert {index} {char}
                    int index = int.Parse(cmdArgs[1]);
                    char ch = char.Parse(cmdArgs[2]);
                    if (IsValidIndex(index, password.Length))
                    {
                        sb.Insert(index, ch);
                        Console.WriteLine(sb.ToString());
                    }
                }
                else if (cmdArgs[0] == "Replace")
                {
                    //Replace {char} {value}
                    int value = int.Parse(cmdArgs[2]);
                    char ch = char.Parse(cmdArgs[1]);
                    if (sb.ToString().Contains(ch))
                    {
                        ReplaceCharWithSum(sb, ch, value);
                    }
                    Console.WriteLine(sb.ToString());
                }
                else if (cmdArgs[0] == "Validation")
                {
                    if (sb.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    for (int i = 0; i < sb.Length; i++)
                    {
                        char currChar = sb[i];

                        if (char.IsDigit(currChar))
                        {
                            counterDigits++;
                        }
                        if (!(char.IsLetter(currChar) || char.IsDigit(currChar) || currChar == '_'))
                        {
                            lettersDigits = false;
                        }
                        if (char.IsUpper(currChar))
                        {
                            isOneUpper = true;
                        }
                        if (char.IsLower(currChar))
                        {
                            isOnelower = true;
                        }

                    }
                    if (!lettersDigits)
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    if (!isOneUpper)
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    if (!isOnelower)
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    if (counterDigits < 1)
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }

                }
            }
            
        }
        static bool IsValidIndex(int index, int length)
        {
            return index >= 0 && index <= length;
        }
        static void ReplaceCharWithSum(StringBuilder password, char ch, int value)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == ch)
                {
                    int asciiValue = (int)ch + value;
                    char newChar = (char)asciiValue;

                    password[i] = newChar;
                }
            }
        }
    }
}