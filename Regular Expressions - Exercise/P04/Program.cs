namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string pattern = @"^[^\@\-\!\:\>]*?\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*?\:(?<population>\d+)[^\@\-\!\:\>]*?\!(?<type>[A|D])\![^\@\-\!\:\>]*?\-\>(?<count>\d+)[^\@\-\!\:\>]*?$";

            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match match = regex.Match(decryptedMessage);
                if (match.Success)
                {
                    string planetName = match.Groups["name"].Value;
                    string attackType = match.Groups["type"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            PrintPlanets(attackedPlanets, "Attacked");
            PrintPlanets(destroyedPlanets, "Destroyed");
        }
        static string DecryptMessage(string encryptedMessage)
        {
            StringBuilder decryptedMesssage = new StringBuilder();
            int decryptionStep = GetDecryptStep(encryptedMessage);

            foreach (char oldCh in encryptedMessage)
            {
                decryptedMesssage.Append((char)(oldCh - decryptionStep));
            }
            return decryptedMesssage.ToString();
        }
        static int GetDecryptStep(string encryptedMessaage)
        {
            int decryptionStep = 0;
            foreach (char ch in encryptedMessaage.ToLower())
            {
                if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r')
                {
                    decryptionStep++;
                }
            }
            return decryptionStep;
        }
        static void PrintPlanets(List<string> planets, string attackType)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");
            foreach (var item in planets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}