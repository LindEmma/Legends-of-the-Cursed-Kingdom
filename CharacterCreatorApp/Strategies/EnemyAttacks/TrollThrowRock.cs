using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class TrollThrowRock : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} throws a rock at {target.Name}... No amount of armour will protect!");
            Random random = new Random();
            int damage = random.Next(7, 17); // Damage range for throwing rock

            target.TakeDamage(damage); // ignores players armour

        }
    }

}
