    using System;

    namespace MyApp // Note: actual namespace depends on the project name.
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                //input
                double money = double.Parse(Console.ReadLine());
                int studentsCount = int.Parse(Console.ReadLine());
                double priceOflightsabers = double.Parse(Console.ReadLine());
                double priceOfRobes = double.Parse(Console.ReadLine());
                double priceOfBelts = double.Parse(Console.ReadLine());


                //actions
                int freeBelts = studentsCount / 6;
                double brokenLightsabers = Math.Ceiling(studentsCount * 1.1);

                double moneyNeeded = (priceOflightsabers * brokenLightsabers) + (priceOfRobes * studentsCount) + priceOfBelts * (studentsCount - freeBelts);


                //output
                if (money >= moneyNeeded)
                {
                    Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
                }
                else
                {
                    Console.WriteLine($"John will need {moneyNeeded - money:f2}lv more.");
                }
            
            }
        }
    }