using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.WarriorAttacks
{
    public class ShieldBash : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.Name} uses Shield Bash! The shield breaks through some of the enemy's armour.");
            Random random = new Random();
            int ap = random.Next(0, 20); //randomizes attack point
            if (ap < target.Armour) //doesn't do damage if ap is lower than armour
            {
                Console.WriteLine("Couldn't breech armour");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(ap - target.Armour + 2);
            }
        }
    }
}
