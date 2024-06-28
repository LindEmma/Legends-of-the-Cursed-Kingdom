using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class LichRaiseUndead : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} raises undead to attack {target.Name}!");
            Random random = new Random();
            int damage = random.Next(5, 15); // Damage range for raising undead
            if (damage < target.Armour)
            {
                Console.WriteLine($"The lich's undead couldn't breech {target.Name}'s armour!");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(damage - target.Armour);
            }
        }
    }

}
