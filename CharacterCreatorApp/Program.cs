namespace CharacterCreatorApp

// Emma Lind .NET23
// Labb 1 - designmönster och arkitektur

// Abstract factory pattern for creating two families of characters (players and enemies),
// strategy pattern for choosing an attack strategy
// & observer makes it possible for the player to choose if they want to view the enemy's health after each round or not.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game CharacterGame = new Game();
            CharacterGame.Run();
        }
    }
}
