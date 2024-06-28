using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies.EnemyAttacks
{
    public class GoblinAmbush : IAttackStrategy
    {
        public void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine($"{attacker.GetType().Name} ambushes {target.Name} from the shadows!");
            Random random = new Random();
            int damage = 0;
            int success = random.Next(0, 2);
            if (success == 0)
            {
                damage = random.Next(0, 6); // if the ambush was unsuccesfull
                Console.WriteLine("The ambush was not successfull.");
            }
            if (success == 1)
            {
                damage = random.Next(10, 30);
                Console.WriteLine("The ambush was successfull!");
            }

            if (damage < target.Armour)
            {
                Console.WriteLine($"...but the ambush couldn't breech {target.Name}'s armour!");
                target.TakeDamage(0);
            }
            else
            {
                target.TakeDamage(damage - target.Armour);
            }
        }
    }

}
