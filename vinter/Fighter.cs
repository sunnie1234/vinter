public class Fighter
{
  public string name;
  public int HP = 50;
  public Sword sword;
  public Shield shield;

  public void Attack(Fighter target)
  {
    int damage = sword.GetDamage();
    target.HP -= damage;
    target.HP = Math.Max(0, target.HP);
    Console.WriteLine($"{name} gör {damage} skada på {target.name}");
  }
}