using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Strategies
{
    public interface IAttackStrategy // strategy pattern
    {
        void Attack(ICharacter attacker, ICharacter target);
    }
}