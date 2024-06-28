using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class GoblinStealArmour : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} attempts to steal armour from {target.Name}!");
            Random random = new Random();
            int successChance = random.Next(0, 101);
            if (successChance > 50) // 50% chance to steal
            {
                int amount = random.Next(0, 3); // Amount stolen
                if (amount > target.Armour && target.Armour > 0)
                {
                    attacker.Armour += target.Armour;
                    target.Armour = 0;
                    Console.WriteLine($"{attacker.GetType().Name} steals the rest of {target.Name}'s armour!");
                }
                else if (target.Armour == 0)
                {
                    Console.WriteLine("There was no armour to steal!");
                }
                else
                {
                    Console.WriteLine($"{attacker.GetType().Name} successfully steals {amount} armour from {target.Name}!");
                    target.Armour -= amount; // takes armour from player
                    if (target.Armour < 0)
                    {
                        target.Armour = 0;
                    }
                    attacker.Armour += amount; // adds armour to enemy
                }

            }
            else
            {
                Console.WriteLine($"{attacker.GetType().Name} fails to steal anything from {target.Name}!");
            }
        }
    }

}
