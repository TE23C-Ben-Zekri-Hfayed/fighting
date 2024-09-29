int heroHp = 100;
int villainHp = 100;
Console.WriteLine($"Name your fighter!");
string heroName = Console.ReadLine();
while (heroName.Length > 20 || heroName.Length == 0)
{
    if (heroName.Length == 0)
    {
    Console.Clear();
    Console.WriteLine("Name can't be empty.");
     heroName = Console.ReadLine();
    }
else if (heroName.Length > 20)
{
Console.Clear();
Console.WriteLine("20 characters exceeded, try again.");
 heroName = Console.ReadLine();
}
}



Console.Clear();
Console.WriteLine($"Name the enemy!");
string villainName = Console.ReadLine();
while (villainName.Length > 20 || villainName.Length == 0)
{
    if (villainName.Length > 20)
    {
    Console.Clear();
    Console.WriteLine("20 characters exceeded, try again.");
    villainName = Console.ReadLine();
    }
    else if (villainName.Length == 0)
    {
        Console.Clear();
        Console.WriteLine("Name can not be empty");
        villainName = Console.ReadLine();
    }
}

Console.Clear();
Console.WriteLine($"Welcome to the dramatic battle between {villainName} and {heroName} ");


Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
    Console.WriteLine("\n----- ===== NEW ROUND ===== -----");
    Console.WriteLine($"{heroName}: {heroHp}  |  {villainName}: {villainHp}\n");
    Console.ReadLine();
    Console.Clear();

    int heroDamage = generator.Next(20);
    villainHp = Math.Max(0, villainHp - heroDamage);
    Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{heroName}");
Console.ResetColor();
    Console.Write($" deals ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{heroDamage}");
    Console.ResetColor();
    Console.WriteLine($" damage to");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write($" {villainName}");
    Console.ResetColor();

    Console.ReadLine();
    Console.Clear();



    int VillainDamage = generator.Next(20);
    heroHp = Math.Max(0, heroHp - VillainDamage);

    Console.Write($"{villainName} deals ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{VillainDamage}");
    Console.ResetColor();
    Console.WriteLine($" damage to {heroName}.");

    Console.ReadLine();
    Console.Clear();

}

Console.WriteLine("\n----- THE MATCH IS OVER -----");

if (heroHp == 0 && villainHp == 0)
{
    Console.WriteLine("It's a TIE!");
}
else if (heroHp == 0)
{
    Console.WriteLine($"{villainName} WON THE MATCH!");
}
else
{
    Console.WriteLine($"{heroName} MATCH!");
}

Console.ReadLine();
