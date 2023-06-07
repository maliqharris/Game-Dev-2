public class Magic : Enemy
{
    public Magic(string name) : base(name)
    {
        Health = 80;
        Attack Fireball = new Attack("Fireball", 25);
        Attack Lightning = new Attack("Lightning Bolt", 25);
        Attack Staff = new Attack("Staff Strike", 25);
        AttackList.Add(Fireball);
        AttackList.Add(Lightning);
        AttackList.Add(Staff);
    }
    public void Heal(Enemy target)
    {
        target.Health += 40;
        Console.WriteLine($"{Name} healed {target.Name}, {target.Name}'s health is now at {target.Health}");
    }
}