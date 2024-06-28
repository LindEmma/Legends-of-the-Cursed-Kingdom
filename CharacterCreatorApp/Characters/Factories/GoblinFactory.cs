using CharacterCreatorApp.Characters.Enemies;

namespace CharacterCreatorApp.Characters.Factories
{
    public class GoblinFactory : IEnemyFactory
    {
        public Enemy CreateCharacter()
        {
            Console.WriteLine("A goblin has spawned");
            return new Goblin();
        }
    }
}
