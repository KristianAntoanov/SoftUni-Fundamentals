using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                for (int i2 = 0; i2 < n; i2++)
                {
                    
                    for (int i3 = 0; i3 < n; i3++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + i2);
                        char thirdChar = (char)('a' + i3);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                        
                    }
                }
                
            }
        }
    }
}