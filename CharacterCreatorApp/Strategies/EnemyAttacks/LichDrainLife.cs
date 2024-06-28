using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class LichDrainLife : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} drains life from {target.Name}!");
            Random random = new Random();
            int damage = random.Next(5, 21);
            if (damage < target.Armour) //doesn't do damage if ap is lower than armour
            {
                Console.WriteLine($"... but couldn't breech {target.Name}'s armour!");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(damage);
                attacker.Health += damage / 2; // Lich heals for half the damage dealt
            }

        }
    }

}
