using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.MageAttacks
{
    public class StaffBash : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.Name} uses staff bash!");
            Random random = new Random();
            int ap = random.Next(10, 20); //randomizes attack point
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
