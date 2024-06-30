using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.WarriorAttacks
{
    public class Shield : IAttackStrategy // göra? - att den hoppar enemies nästa runda
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.Name} uses Axe Attack!");
            Random random = new Random();
            int ap = random.Next(0, 20); //randomizes attack point
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
