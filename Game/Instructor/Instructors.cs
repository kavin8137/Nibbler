// importing necessary namespaces
using Game.Nibbler;
using Game.Scenarios;
using Game.Services;

namespace Game.Instruct
{
    // defining the Instructor class that manages the game loop and actions
    // this class is responsible for starting the game, executing actions, and managing the game window
    public class Instructor
    {
        private Video? _video = null;

        public Instructor(Video video)
        {
            this._video = video;
        }
        // defining the StartGame method that initializes the game loop
        // this method takes a Cast object and a Script object as parameters
        public void StartGame(Cast cast, Script script)
        {
            _video!.OpenWindow();
            _video.LoadTexture();
            while (_video.IsWindowOpen())
            {
                ExecuteActions("input", cast, script);
                ExecuteActions("update", cast, script);
                ExecuteActions("output", cast, script);
            }
            _video.CloseWindow();
        }
        // defining the ExecuteActions method that executes actions based on the group name
        // this method takes a group name, a Cast object, and a Script object as parameters
        private void ExecuteActions(string group, Cast cast, Script script)
        {
            var actions = script.GetActions(group);
            foreach(var action in actions)
            {
                action.Execute(cast, script);
            }
        }
    }
}