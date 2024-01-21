namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool IsPassLengthValid = IsPasswordLengthValid(inputPassword);
            bool IsPassAlphaNumeric = IsPasswordAlphaNumeric(inputPassword);
            bool IsPassHasTwoDigitsOrMore = IsPasswordHasTwoDigitsOrMore(inputPassword);
            if (!IsPassLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsPassAlphaNumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsPassHasTwoDigitsOrMore)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsPassLengthValid && IsPassHasTwoDigitsOrMore && IsPassAlphaNumeric)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordLengthValid (string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordAlphaNumeric (string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordHasTwoDigitsOrMore (string password)
        {
            int count = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    count++;
                }
            }
            return count >= 2;
        }

    }
}