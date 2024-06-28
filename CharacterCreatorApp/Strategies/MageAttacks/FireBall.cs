using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.MageAttacks
{
    public class FireBall : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Random random = new Random();
            int ap = random.Next(5, 15); //randomizes attack point

            Console.WriteLine($"{attacker.GetType().Name} throws a fire ball, it goes straight through the enemy's armour!");
            target.TakeDamage(ap);
        }
    }
}
