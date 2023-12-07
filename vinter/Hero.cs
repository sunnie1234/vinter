

class Hero : Fighter
{
    public Hero()
    {
        shield = new();
        sword = new();
    }

    public override void ValAttack(Fighter target)
    {
        Console.WriteLine("tryck 1 för att shielda, tryck 2 för att attackera");

        string val = Console.ReadLine();

        if (val == "1")
        {
            if (target.shield.Active)
            {
                target.damage = 0;
            }
            else
            {
                shield.Active = true;
            }

        }
        else if (val == "2")
        {
            shield.Active = false;
            // sword.Active = true;
            Attack(target);
        }
    }

    public void Val()
    {
        Console.WriteLine("tryck 1 för att shielda, tryck 2 för att attackera");

        string val = Console.ReadLine();

        if (val == "1")
        {
            shield.Active = true;
        }
        else if (val == "2")
        {
            shield.Active = false;
        }
    }

    public void Action(Fighter target)
    {
        if (!shield.Active)
        {
            Attack(target);
        }
    }
}