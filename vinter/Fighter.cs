public class Fighter
{
  public string name;
  public int HP = 50;
  public Sword sword;
  public Shield shield;
  public int damage;

  public Fighter()
  {
  }

  public void Attack(Fighter target)
  {
    damage = sword.GetDamage();
    int savedHP = target.shield.ShieldDamage();
    damage -= savedHP;
    target.HP -= damage;
    target.HP = Math.Max(0, target.HP);
    Console.WriteLine($"{target.name} skyddar {savedHP} från {name}");
    Console.WriteLine($"{name} gör {damage} skada på {target.name}\n");


  }

  public virtual void ValAttack(Fighter target)
  {

  }

}