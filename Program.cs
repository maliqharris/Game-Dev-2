Enemy Steve = new Enemy("Steve");
Attack Taxes = new Attack("Taxes", 15);
Attack CalculatorThrow = new Attack("Calculator Throw!", 10);
Attack Flail = new Attack("flail", 5);

Steve.AttackList.Add(Taxes);
Steve.AttackList.Add(CalculatorThrow);
Steve.AttackList.Add(Flail);

Steve.RandomAttack();
Melee Axeman = new Melee("Axeman");
Ranged Bowman = new Ranged("Bowman");
Magic MagicMan = new Magic("Magic Man!");
// Steve.PerformAttack(Bowman, Taxes );
Axeman.PerformAttack(Bowman, Axeman.AttackList[1]);
Axeman.Rage(MagicMan);
Bowman.PerformAttack(Axeman, Bowman.AttackList[0]);
Bowman.Dash();
Bowman.PerformAttack(Axeman, Bowman.AttackList[0]);
MagicMan.PerformAttack(Axeman, MagicMan.AttackList[0]);
MagicMan.Heal(Bowman);
MagicMan.Heal(MagicMan);
