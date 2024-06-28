using CharacterCreatorApp.Characters;
using CharacterCreatorApp.Characters.Factories;
using CharacterCreatorApp.Observers;
using Spectre.Console;

namespace CharacterCreatorApp
{
    internal class Game
    {
        public bool RunGame { get; set; }
        private string[] dungeonEntranceDescriptions { get; set; }

        public Game()
        {
            RunGame = true;
            dungeonEntranceDescriptions = new string[]
    {
        "As you descend into the dungeon's depths, the air grows cold and stale. Shadows cling to the walls, whispering secrets of ancient evils that stir in the darkness.",
        "Stepping into the dungeon, the musty smell of decay assaults your senses. Dim torchlight flickers, revealing winding corridors that seem to shift and twist with malevolent intent.",
        "Entering the dungeon, you feel a chill run down your spine as eerie echoes bounce off the moss-covered stones. In the gloom, the faint glint of treasure beckons amidst forgotten relics and perilous traps.",
        "Venturing into the dungeon, the oppressive silence is broken only by the drip of water echoing in unseen chambers. Shadows flicker, hinting at creatures lurking just beyond the edge of your vision.",
        "Descending into darkness, the dungeon's ancient stones groan beneath your feet. The air is thick with anticipation, as if the very walls hold their breath, waiting for your next move amidst the labyrinthine paths."
    };
        }
        public void QuitGame()
        {
            RunGame = false;
            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();
        }
        public void Run()
        {
            Console.WriteLine("\nIn the forsaken land of Eldoria, darkness reigns and evil creatures run rampant. As a chosen hero, you must battle goblins, trolls, and other sinister foes to lift the curse." +
                    "\nYour legend begins now.\n");

            Thread.Sleep(3000);

            while (RunGame)
            {
                AnsiConsole.Write(
                new FigletText("Legends of the Cursed Kingdom")
                .LeftJustified()
                 .Color(Color.Cyan1));

                Thread.Sleep(1000);
                AnsiConsole.MarkupLine("\n[rapidblink]Press any key to continue[/]");
                Console.ReadKey();
                Console.Clear();

                AnsiConsole.Status()
                .Start("Thinking...", ctx =>
                {
                    // simulate loading game
                    AnsiConsole.MarkupLine("Loading game...");
                    Thread.Sleep(2000);


                    ctx.Spinner(Spinner.Known.Star);
                    ctx.SpinnerStyle(Style.Parse("green"));


                });
                Console.Clear();

                // Abstract factory pattern
                var creator = new CharacterCreator();
                Player player = creator.ChooseClass();
                player.NameCharacter();
                AnsiConsole.MarkupLine("\n[rapidblink]Press any key when you are ready to enter the dungeon[/]");
                Console.ReadKey();
                Console.Clear();

                Random random = new Random();
                string dungeonEntranceDescription = dungeonEntranceDescriptions[random.Next(dungeonEntranceDescriptions.Length)];

                Console.WriteLine(dungeonEntranceDescription + "\n");


                Enemy enemy = creator.RandomizeEnemy();

                // Observer pattern
                ConsoleObserver consoleObserver = new ConsoleObserver();
                enemy.Attach(consoleObserver);
                AnsiConsole.MarkupLine("\n[yellow]********************* TOGGLE LIFEBAR ************************\n" +
                    "* Do you want to see enemy's health after each attack? (Y/N)*\n" +
                    "*************************************************************[/]\n");
                string input = Console.ReadLine();
                bool showEnemyHealth;
                if (input == "Y" || input == "y")
                {
                    showEnemyHealth = true;
                }
                else
                {
                    showEnemyHealth = false;
                }
                AnsiConsole.MarkupLine("[rapidblink]Press any key when you are ready to play![/]");
                Console.ReadKey();
                Console.Clear();
                while (player.IsAlive && enemy.IsAlive)
                {
                    player.ChooseAttackStrategy(); // strategy pattern
                    player.Attack(enemy);
                    if (enemy.IsAlive)
                    {
                        enemy.ChooseAttackStrategy();
                        enemy.Attack(player);
                    }
                    if (showEnemyHealth)
                    {
                        enemy.Notify();
                    }

                }
                if (player.IsAlive)
                {
                    AnsiConsole.MarkupLine("[Green]You have won![/]");
                }
                else
                {
                    AnsiConsole.MarkupLine("[Red]GAME OVER[/]");
                }

                AnsiConsole.MarkupLine("\n[Cyan]Do you want to play again?([/][Green]Y[/][Cyan]/[/][Red]N[/][Cyan])[/]");
                string answer = Console.ReadLine();

                if (answer != "y" || answer != "n" || answer != "Y" || answer != "N")
                {
                    Console.WriteLine("Please choose Y or N");
                    answer = Console.ReadLine();
                }
                else if (answer.ToLower() == "n")
                {
                    QuitGame();
                }
                Console.Clear();
            }
        }
    }
}

