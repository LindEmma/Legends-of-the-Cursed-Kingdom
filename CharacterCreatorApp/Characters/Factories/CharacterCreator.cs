namespace CharacterCreatorApp.Characters.Factories
{
    public class CharacterCreator
    {
        private readonly List<Tuple<string, IPlayerFactory>> players; // list of players
        private readonly List<Tuple<string, IEnemyFactory>> enemies; // list of enemies
        public CharacterCreator()
        {
            players = new List<Tuple<string, IPlayerFactory>>();
            enemies = new List<Tuple<string, IEnemyFactory>>();

            RegisterPlayer<WarriorFactory>("Warrior");
            RegisterPlayer<MageFactory>("Mage");

            RegisterEnemy<GoblinFactory>("Goblin");
            RegisterEnemy<LichFactory>("Lich");
            RegisterEnemy<TrollFactory>("Troll");
        }
        private void RegisterPlayer<T>(string characterName) where T : IPlayerFactory, new()
        {
            players.Add(Tuple.Create(characterName, (IPlayerFactory)Activator.CreateInstance(typeof(T)))); // Adds factory to list
        }
        private void RegisterEnemy<T>(string enemyName) where T : IEnemyFactory, new()
        {
            enemies.Add(Tuple.Create(enemyName, (IEnemyFactory)Activator.CreateInstance(typeof(T)))); // adds enemy factory to list
        }
        public Player ChooseClass() // lets player choose a character class
        {
            Console.WriteLine("Choose your character");
            for (var index = 0; index < players.Count; index++)
            {
                var tuple = players[index];
                Console.WriteLine($"{index}: {tuple.Item1}"); // prints the classes to choose from
            }
            Console.WriteLine("Select a number to continue:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int i) && i >= 0 && i < players.Count)
                {

                    return players[i].Item2.CreateCharacter();

                }
                Console.WriteLine("Something went wrong with your input, try again."); // if user-input is invalid
            }
        }
        public Enemy RandomizeEnemy() //chooses a randomized enemy
        {
            Random random = new Random();
            int enemyListLength = enemies.Count;
            int randomEnemyIndex = random.Next(0, enemyListLength);

            var selectedEnemy = enemies[randomEnemyIndex];
            //Console.WriteLine($"A {selectedEnemy.Item1} has spawned!");

            return selectedEnemy.Item2.CreateCharacter();
        }
    }
}
