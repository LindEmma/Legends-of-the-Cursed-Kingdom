using CharacterCreatorApp.Characters.Players;

namespace CharacterCreatorApp.Characters.Factories
{
    public class MageFactory : IPlayerFactory
    {
        public Player CreateCharacter()
        {
            Console.WriteLine("Mage is ready ready to unleash a storm of arcane knowledge!");
            return new Mage();
        }
    }
}
