using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.WarriorAttacks
{
    public class SwordAttack : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.Name} uses Sword Attack!");
            Random random = new Random();
            int ap = random.Next(0, 20); //randomizes attack point
            if (ap < target.Armour) //doesn't do damage if ap is lower than armour
            {
                Console.WriteLine("Couldn't breech armour");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(ap - target.Armour);
            }

        }
    }
}
