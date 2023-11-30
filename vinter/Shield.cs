public class Shield
{
    private Random generator;

    public bool Active = true;
    

     public Shield()
    {
    generator = new Random();
    }

     public int ShieldDamage()
    {
        
            return generator.Next(10, 20);
        
    
     }
}