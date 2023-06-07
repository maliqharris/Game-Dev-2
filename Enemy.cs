public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        // As empty list
        AttackList = new List<Attack>();
    }
    public void RandomAttack()
    {
        Random random = new Random();
        int randInd = random.Next(0, AttackList.Count);
        Attack randomAttack = AttackList[randInd];
        Console.WriteLine(Name + " preforms " + randomAttack.Name);
    }
    // Inside of the Enemy class
    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        Target.Health = Target.Health - ChosenAttack.DamageAmount;

        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }

}