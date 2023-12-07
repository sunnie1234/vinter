
// Fighter hero = new Fighter();

// Fighter villain = new Fighter();

Hero hero = new Hero();

Villain villain = new Villain();



hero.name = "HERO";


villain.name = "VILLAIN";

// villain.shield.name = "Bright shield";




// Random generator = new Random();

while (hero.HP > 0 && villain.HP > 0)
{
  // Console.Clear();

  Console.WriteLine($"{hero.name}: {hero.HP} || {villain.name}: {villain.HP}\n");


  hero.Val();
  villain.Val();

  hero.Action(villain);
  villain.Action(hero);

  // villain.ValAttack(hero);

  // Console.ReadLine();
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();

// Console.WriteLine($"{hero.name}: {hero.HP} || {villain.name}: {villain.HP}\n");

/* Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (hero.HP == 0 && villain.HP == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (hero.HP == 0)
{
  Console.WriteLine($"{villain.name} vann!");
}
else
{
  Console.WriteLine($"{hero.name} vann!");
}

 */ 