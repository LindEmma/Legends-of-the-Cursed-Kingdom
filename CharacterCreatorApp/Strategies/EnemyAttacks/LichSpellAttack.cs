using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class LichSpellAttack : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} casts a dark spell on {target.Name}!");
            Random random = new Random();
            int damage = random.Next(9, 26);
            if (damage < target.Armour) //doesn't do damage if ap is lower than armour
            {
                Console.WriteLine($"{attacker.GetType().Name} couldn't breech {target.Name}'s armour!");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(damage - target.Armour);
            }
        }
    }

}
