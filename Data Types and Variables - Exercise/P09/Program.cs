namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int spice = int.Parse(Console.ReadLine());

            int currSpice = 0;

            int days = 0;
            int allSpices = 0;
            if (spice >= 100)
            {


                while (spice >= 100)
                {

                    allSpices += spice;
                    spice -= 10;
                    currSpice = spice;
                    days++;

                    if (currSpice < 100)
                    {
                        break;
                    }
                }
                Console.WriteLine(days);
                Console.WriteLine(allSpices - days * 26 - 26);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(currSpice);
            }
            
        }
    }
}