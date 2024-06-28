using CharacterCreatorApp.Strategies;
using CharacterCreatorApp.Strategies.EnemyAttacks;

namespace CharacterCreatorApp.Characters.Enemies
{
    public class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Goblin";
            Description = "A sneaky little creature with a penchant for mischief.";
            Health = 100;
            Armour = 5;
            _availableStrategies = new List<IAttackStrategy>
        {
            new GoblinStabAttack(),
            new GoblinAmbush(),
            new GoblinStealArmour()
        };
            _attackStrategy = _availableStrategies[0]; // Standardattack
        }
    }
}
