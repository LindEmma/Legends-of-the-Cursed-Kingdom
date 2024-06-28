using CharacterCreatorApp.Characters;

namespace CharacterCreatorApp.Observers
{
    public interface IObserver //observer interface
    {
        void Update(ICharacter enemy);
    }
}
