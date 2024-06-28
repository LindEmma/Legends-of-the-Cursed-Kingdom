using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class TrollSmashAttack : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} smashes {target.Name} with a giant club!");
            Random random = new Random();
            int damage = random.Next(12, 22); // Damage range for smash attack
            if (damage < target.Armour)
            {
                Console.WriteLine($"The troll couldn't breech {target.Name}'s armour!");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(damage - target.Armour);
            }
        }
    }
}
