using System;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string reversedName = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversedName += username[i];
            }
            int counter = 1;
            while (password != reversedName)
            {
              
                if (counter > 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                counter++;
            }
            if (password == reversedName)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
        }
    }
}