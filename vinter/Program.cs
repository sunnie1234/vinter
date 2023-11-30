
Fighter hero = new Fighter();



// hero.name = "HERO";
// hero.sword = new Sword();
// hero.sword.name = "Dark sword";
// hero.shield = new Shield();
// hero.shield.name = "Dark shield";

// Fighter villain = new Fighter();
// villain.name = "VILLAIN";
// villain.sword = new Sword();
// villain.sword.name = "Bright sword";
// villain.shield = new Shield();
// villain.shield.name = "Bright shield";




Random generator = new Random();

while (hero.HP > 0 && villain.HP > 0)
{
  
  

  hero.Attack(villain);
  villain.Attack(hero);

 
}

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

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey(); */ 