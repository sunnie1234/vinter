public class Shield
{
    public bool Active = true;


    public Shield()
    {

    }

    public int ShieldDamage()
    {
        if (Active == true)
        {
            // Console.WriteLine("Shield protected!");
            return Random.Shared.Next(10, 15);
        }
        else
        {
            return 0;
        }


    }
}