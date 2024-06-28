using CharacterCreatorApp.Characters.Enemies;

namespace CharacterCreatorApp.Characters.Factories
{
    public class TrollFactory : IEnemyFactory
    {
        public Enemy CreateCharacter()
        {
            Console.WriteLine($"A troll has spawned!");
            return new Troll();
        }
    }
}
