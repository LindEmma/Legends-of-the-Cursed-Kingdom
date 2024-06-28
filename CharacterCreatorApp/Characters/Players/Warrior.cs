using CharacterCreatorApp.Strategies;
using CharacterCreatorApp.Strategies.WarriorAttacks;

namespace CharacterCreatorApp.Characters.Players
{
    public class Warrior : Player
    {
        public Warrior()
        {
            Description = "A brave and strong warrior skilled in melee combat.";
            Health = 100;
            Armour = 10;
            _availableStrategies = new List<IAttackStrategy> // warriors attacks
        {
            new SwordAttack(),
            new Shield(),
            new ShieldBash()
        };
            _attackStrategy = _availableStrategies[0]; // Standard attack if nothing else is chosen
        }
    }
}
