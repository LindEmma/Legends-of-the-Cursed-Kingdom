using CharacterCreatorApp.Characters;
using Spectre.Console;

namespace CharacterCreatorApp.Observers
{
    public class ConsoleObserver : IObserver
    {
        public void Update(ICharacter enemy)
        {
            AnsiConsole.MarkupLine($"[darkorange3_1]** Enemy's health is: {enemy.Health} **[/]\n"); // shows  this if player wants to be notified
        }
    }
}
