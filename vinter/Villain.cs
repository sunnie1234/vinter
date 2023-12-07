

using System.Runtime;

public class Villain : Fighter
{
    public Villain()
    {
        shield = new();
        sword = new();
    }
    public void Val()
    {

        int val = Random.Shared.Next(1, 3);

        if (val == 1)
        {
           
                shield.Active = true;
            
        }
         else if (val == 2)
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
