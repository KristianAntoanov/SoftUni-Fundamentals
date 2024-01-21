namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> hp = new Dictionary<string, int>();
            Dictionary<string, int> mp = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            //{hero name} {HP} {MP}
            for (int i = 0; i < n; i++)
            {
                string[] heroes = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                hp[heroes[0]] = int.Parse(heroes[1]);
                mp[heroes[0]] = int.Parse(heroes[2]);
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArg = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string commands = cmdArg[0];
                if (commands == "CastSpell")
                {
                    string heroName = cmdArg[1];
                    int mpNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];
                    if (mp[heroName] >= mpNeeded)
                    {
                        mp[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {mp[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (commands == "TakeDamage")
                {
                    //TakeDamage – {hero name} – {damage} – {attacker}
                    string heroName = cmdArg[1];
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];
                    hp[heroName] -= damage;
                    if (hp[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {hp[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        hp.Remove(heroName);
                    }
                }
                else if (commands == "Recharge")
                {
                    //Recharge – {hero name} – {amount}
                    string heroName = cmdArg[1];
                    int amount = int.Parse(cmdArg[2]);
                    int currentAmount = mp[heroName];
                    mp[heroName] += amount;
                    int amountRecovered = amount;
                    if (mp[heroName] > 200)
                    {
                        amountRecovered = 200 - currentAmount;
                        mp[heroName] = 200;
                    }
                    Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
                }
                else if (commands == "Heal")
                {
                    //Heal – {hero name} – {amount}
                    string heroName = cmdArg[1];
                    int amount = int.Parse(cmdArg[2]);
                    int amountRecovered = amount;
                    int currentAmount = hp[heroName];
                    hp[heroName] += amount;
                    if (hp[heroName] > 100)
                    {
                        amountRecovered = 100 - currentAmount;
                        hp[heroName] = 100;
                    }
                    Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
                }
            }
            foreach (var item in hp)
            {
                string name = item.Key;
                Console.WriteLine(name);
                Console.WriteLine($"  HP: {item.Value}");
                Console.WriteLine($"  MP: {mp[name]}");
            }
        }
    }
}