namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (commands[0] == "Add")
                {
                    string cardName = commands[1];
                    if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");
                        continue;
                    }
                    cards.Add(cardName);
                    Console.WriteLine("Card successfully added");
                }
                else if (commands[0] == "Remove")
                {
                    string cardName = commands[1];
                    if (cards.Contains(cardName))
                    {
                        cards.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                        continue;
                    }
                    Console.WriteLine("Card not found");
                }
                else if (commands[0] == "Remove At")
                {
                    int index = int.Parse(commands[1]);
                    if (index < 0 || index > cards.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    cards.RemoveAt(index);
                    Console.WriteLine("Card successfully removed");
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string cardName = commands[2];
                    if (index < 0 || index > cards.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already added");
                        continue;
                    }
                    cards.Insert(index, cardName);
                    Console.WriteLine("Card successfully added");
                }
                
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}