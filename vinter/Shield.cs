public class Shield
{
    private Random generator;

     public Shield()
    {
    generator = new Random();
    }

     public int ShieldDamage()
    {
    return generator.Next(10, 20);
     }
}