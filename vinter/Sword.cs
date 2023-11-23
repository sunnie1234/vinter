
public class Sword
{
    public string name;
    private Random generator;

    public Sword()
    {
    generator = new Random();
    }

     public int GetDamage()
    {
    return generator.Next(10, 20);
     }
}