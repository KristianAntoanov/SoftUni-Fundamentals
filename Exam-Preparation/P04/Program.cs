namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double priceWithoutWaxes = 0;
            double totalPrice = 0;
            double taxes = 0;
            bool isValid = false;

            while ((input = Console.ReadLine()) != "regular")
            {
                if (input == "special")
                {
                    break;
                }
                double currPrice = double.Parse(input);
                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                priceWithoutWaxes += currPrice;
                taxes += currPrice * 0.2;
                isValid = true;
            }
            if (input == "regular")
            {
                totalPrice = taxes + priceWithoutWaxes;
            }
            else
            {
                totalPrice = (taxes + priceWithoutWaxes) * 0.9;
            }
            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            if (isValid)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutWaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}