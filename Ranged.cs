public class Ranged : Enemy
{
    public int Distance { get; set; }
    public Ranged(string name) : base(name)
    {
        Distance = 5;
        Attack Arrow = new Attack("Shoot an Arrow", 20);
        Attack Knife = new Attack("Throw a Knife", 15);
        AttackList.Add(Arrow);
        AttackList.Add(Knife);
    }
    public virtual void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if ( Distance > 9)
        {
            base.PerformAttack(target, chosenAttack);
        }
        else
        {
            Console.WriteLine($"{target.Name} is too close!");
        }
    }
    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} has distanced themselves! Distance increased to 20!");
    }
}