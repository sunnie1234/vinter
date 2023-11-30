

class Hero: Fighter
{
   Shield shield = new Shield();
    public override void ValAttack(Fighter target)
    {
        Console.WriteLine ("tryck 1 för att shielda, tryck 2 för att attackera");

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
}