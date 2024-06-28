using CharacterCreatorApp.Strategies;
using CharacterCreatorApp.Strategies.EnemyAttacks;

namespace CharacterCreatorApp.Characters.Enemies
{
    internal class Troll : Enemy
    {
        public Troll()
        {
            Name = "Troll";
            Description = "A sneaky little troll";
            Health = 80;
            Armour = 7;
            _availableStrategies = new List<IAttackStrategy>
            {
            new TrollThrowRock(),
            new TrollRegenerate(),
            new TrollSmashAttack()
        };
            _attackStrategy = _availableStrategies[0]; // Standardattack
        }
    }
}
