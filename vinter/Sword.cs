
public class Sword
{
    public string name;

    public Sword()
    {

    }

    public int GetDamage()
    {
        return Random.Shared.Next(10, 20);
    }
}