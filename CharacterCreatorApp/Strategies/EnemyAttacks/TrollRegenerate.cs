using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class TrollRegenerate : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} stops the fight to dig through it's pockets in search for a strange smelling herb...");
            Random random = new Random();
            int healAmount = random.Next(5, 15); // Heal amount range
            attacker.Health += healAmount;
            Console.WriteLine($"{attacker.GetType().Name} gains {healAmount} health!");
        }
    }

}
