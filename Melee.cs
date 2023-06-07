public class Melee : Enemy
{
    public Melee(string name) : base(name)
    {
        Health = 120;
        Attack Punch = new Attack("Punch", 20);
        Attack Kick = new Attack("Kick", 15);
        Attack Tackle = new Attack("Tackle", 25);
        AttackList.Add(Punch);
        AttackList.Add(Kick);
        AttackList.Add(Tackle);
    }
    public void Rage(Enemy Target)
    {
        Random random = new Random();
        int randInd = random.Next(0, AttackList.Count);
        Attack randomAttack = AttackList[randInd];
        int rageDamage = randomAttack.DamageAmount + 10;
        Target.Health -= rageDamage;
        Console.WriteLine($"{Name} preforms {randomAttack.Name} with Spartan Rage!, dealing an incredible {rageDamage} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }
   
}