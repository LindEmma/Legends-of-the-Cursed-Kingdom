using CharacterCreatorApp.Strategies;
using CharacterCreatorApp.Strategies.EnemyAttacks;

namespace CharacterCreatorApp.Characters.Enemies
{
    public class Lich : Enemy
    {
        public Lich()
        {
            Name = "Lich";
            Description = "A sneaky little LICH";
            Health = 130;
            Armour = 0;
            _availableStrategies = new List<IAttackStrategy>
        {
            new LichRaiseUndead(),
            new LichDrainLife(),
            new LichSpellAttack()
        };
            _attackStrategy = _availableStrategies[0]; // Standardattack
        }
    }
}
