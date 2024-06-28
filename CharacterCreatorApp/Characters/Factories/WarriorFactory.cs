using CharacterCreatorApp.Characters.Players;

namespace CharacterCreatorApp.Characters.Factories
{
    public class WarriorFactory : IPlayerFactory
    {
        public Player CreateCharacter()
        {
            Console.WriteLine("Warrior is ready to fight, as always!");
            return new Warrior();
        }
    }
}
