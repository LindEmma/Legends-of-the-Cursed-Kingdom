using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class GoblinStabAttack : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} stabs {target.Name} with a dagger!");
            Random random = new Random();
            int damage = random.Next(4, 10); // Damage range for stab attack
            if (damage < target.Armour)
            {
                Console.WriteLine($"The goblin couldn't breech {target.Name}'s armour!");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(damage - target.Armour);
            }
        }
    }

}
