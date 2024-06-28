using CharacterCreatorApp.Characters.Enemies;

namespace CharacterCreatorApp.Characters.Factories
{
    public class LichFactory : IEnemyFactory
    {
        public Enemy CreateCharacter()
        {
            Console.WriteLine("A lich has spawned");
            return new Lich();
        }
    }
}
