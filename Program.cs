// importing necessary namespaces
using Game.Nibbler;
using Game.Instruct;
using Game.Scenarios;
using Game.Services;
using Game;

// constructing the main program class
namespace NibblerGame
{
    // defining the main entry point of the program
    class Program
    {
        // defining the main method
        static void Main(string[] args)
        {
            // initializing the game components
            Constants constants = new Constants();
            // creating a new cast object to hold game actors
            Cast cast = new Cast();
            // adding actors to the cast
            cast.AddActor("food", new Food());
            cast.AddActor("snake", new Snake(1, Constants.GREEN, Constants.YELLOW));
            cast.AddActor("snake1", new Snake(2, Constants.BLUE, Constants.CYAN));
            cast.AddActor("banner1", new Banner(0, "Player 1:", Constants.GREEN));
            cast.AddActor("banner2", new Banner(2, "Player 2:", Constants.CYAN));

            // creating a new keyboard object to handle user input
            var keyboard = new Keyboard();
            var video = new Video(debug: false);
           
            // creating the script object to manage game actions
            var script = new Script();
            script.AddAction("input", new ControlActors(keyboard));
            script.AddAction("update", new MoveActors());
            script.AddAction("update", new HandleCollisions());
            script.AddAction("update", new PlayMusic());
            script.AddAction("output", new DrawActors(video));

            // start the game
            Instructor instructor = new Instructor(video);
            Audio.Init();
            instructor.StartGame(cast, script);
            Audio.Stop();
        }
    }
}