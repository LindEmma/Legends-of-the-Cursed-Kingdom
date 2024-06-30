using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.MageAttacks
{
    public class Heal : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.Name} heals itself!");
            attacker.Health += 15;
            Console.WriteLine($"{attacker.GetType().Name} went from {attacker.Health - 15} to {attacker.Health} health");
            target.TakeDamage(0);
        }
    }
}
