int heroHp = 100;
int villainHp = 100;

string heroName = "Serious";
string villainName = "Johnkler";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
    Console.WriteLine("\n----- ===== NEW ROUND ===== -----");
    Console.WriteLine($"{heroName}: {heroHp}  |  {villainName}: {villainHp}\n");
    Console.ReadLine();
    Console.Clear();


    int heroDamage = generator.Next(20);
    villainHp = Math.Max(0, villainHp - heroDamage);
    Console.WriteLine($"{heroName} deals {heroDamage} damage to {villainName}.");
    Console.ReadLine();

    Console.Clear();

    
    int villainDamage = generator.Next(20);
    heroHp = Math.Max(0, heroHp - villainDamage);
    Console.WriteLine($"{villainName} deals {villainDamage} damage to {heroName}.");
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
