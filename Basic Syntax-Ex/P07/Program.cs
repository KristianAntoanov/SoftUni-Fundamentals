namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            double sumOfCoins = 0;

            while (coins != "Start")
            {
                double currCoins = double.Parse(coins);

                if (currCoins == 0.1)
                {
                    sumOfCoins += 0.1;
                }
                else if (currCoins == 0.2)
                {
                    sumOfCoins += 0.2;
                }
                else if (currCoins == 0.5)
                {
                    sumOfCoins += 0.5;
                }
                else if (currCoins == 1)
                {
                    sumOfCoins += 1;
                }
                else if (currCoins == 2)
                {
                    sumOfCoins += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                coins = Console.ReadLine();
            }
            string products;
            while ((products = Console.ReadLine()) != "End")
            {
                if (products == "Nuts" && sumOfCoins >= 2)
                {
                    Console.WriteLine("Purchased nuts");
                    sumOfCoins -= 2;
                }
                else if (products == "Water" && sumOfCoins >= 0.7)
                {
                    Console.WriteLine("Purchased water");
                    sumOfCoins -= 0.7;
                }
                else if (products == "Crisps" && sumOfCoins >= 1.5)
                {
                    Console.WriteLine("Purchased crisps");
                    sumOfCoins -= 1.5;
                }
                else if (products == "Soda" && sumOfCoins >= 0.8)
                {
                    Console.WriteLine("Purchased soda");
                    sumOfCoins -= 0.8;
                }
                else if (products == "Coke" && sumOfCoins >= 1)
                {
                    Console.WriteLine("Purchased coke");
                    sumOfCoins -= 1;
                }
                else if (products != "Coke" && products != "Soda" && products != "Crisps" && products != "Water" && products != "Nuts")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

            }
                Console.WriteLine($"Change: {sumOfCoins:f2}");

        }
    }
}