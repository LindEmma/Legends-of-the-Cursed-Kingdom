using CharacterCreatorApp.Strategies;
using CharacterCreatorApp.Strategies.MageAttacks;

namespace CharacterCreatorApp.Characters.Players
{
    public class Mage : Player
    {
        public Mage()
        {
            Description = "After ages of studying the arcane arts, his mind is the sharpest weapon in the realm.";
            Health = 100;
            Armour = 0;
            _availableStrategies = new List<IAttackStrategy> // mages attacks
        {
            new FireBall(),
            new StaffBash(),
            new Heal()
        };
            _attackStrategy = _availableStrategies[0]; // Standard attack
        }
    }
}
