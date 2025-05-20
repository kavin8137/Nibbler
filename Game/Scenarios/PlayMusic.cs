// importing necessary namespaces
using Game.Nibbler;
using Game.Services;

namespace Game.Scenarios
{
    public class PlayMusic : Action
    {
        // defining the method that will ensure the music plays
        public void Execute(Cast cast, Script script)
        {
            Audio.Update();
        }
    }
}