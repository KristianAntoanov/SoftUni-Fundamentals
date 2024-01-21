namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> allProducts = new Dictionary<string, double>();
            Dictionary<string, int> quantityOfProducts = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = cmdArgs[0];
                double priceForOne = double.Parse(cmdArgs[1]);
                int quantity = int.Parse(cmdArgs[2]);

                if (!allProducts.ContainsKey(product))
                {
                    allProducts[product] = 0;
                    quantityOfProducts[product] = quantity;
                }
                else
                {
                    int oldQuantity = quantityOfProducts[product];
                    quantityOfProducts[product] = oldQuantity + quantity;
                    quantity += oldQuantity;
                }
                allProducts[product] = priceForOne * quantity;
            }
            foreach (var item in allProducts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}