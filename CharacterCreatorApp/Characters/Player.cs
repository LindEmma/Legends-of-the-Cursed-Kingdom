using CharacterCreatorApp.Strategies;
using Spectre.Console;

namespace CharacterCreatorApp.Characters
{
    public abstract class Player : ICharacter //abstract factory - abstract class for all playable characters
    {
        public string Description { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Health { get; set; }
        public int Armour { get; set; }

        public IAttackStrategy _attackStrategy;
        public List<IAttackStrategy> _availableStrategies; //list of attack strategies linked to the character

        public bool IsAlive => Health > 0; // player is alive is health is more than 0


        public void Attack(ICharacter target) // attacks enemy
        {
            if (_attackStrategy == null)
            {
                Console.WriteLine("No attack strategy set!");
                return;
            }

            if (IsAlive)
            {
                _attackStrategy.Attack(this, target);
            }
        }

        public void TakeDamage(int damage) //takes damage from enemy
        {
            Health -= damage;
            if (damage == 0)
            {
                AnsiConsole.MarkupLine($"{Name} takes {damage} damage, phew!\n[Cyan]** {Name}'s health is: {Health} **[/]");
            }
            else
            {
                AnsiConsole.MarkupLine($"{Name} takes {damage} damage, ouch!\n[Cyan]** {Name}'s health is: {Health} **[/]");
            }
        }

        public void ChooseAttackStrategy() // lets playyer choose an attack
        {
            Console.WriteLine("Choose an attack strategy:");
            for (int i = 0; i < _availableStrategies.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {_availableStrategies[i].GetType().Name}");
            }

            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _availableStrategies.Count)
            {
                _attackStrategy = _availableStrategies[choice - 1];
            }
            else
            {
                Console.WriteLine("Invalid choice, using default strategy.");
                _attackStrategy = _availableStrategies[0];
            }
        }
        public void NameCharacter() // method to name players character
        {
            string name = "";
            while (name == null || name.Length < 1)
            {
                Console.WriteLine("\nWhat will you name your character?");
                name = Console.ReadLine();
                Console.WriteLine($"{name} is ready to fight!\n");
            }
            Name = name;
        }
    }
}
