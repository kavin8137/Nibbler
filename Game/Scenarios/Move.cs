using Game.Nibbler;

namespace Game.Scenarios
{
    // This class is responsible for moving actors in the game.
    // It implements the Action interface, which defines the Execute method.
    public class MoveActors : Action
    {
        public MoveActors()
        {
        }
        public void Execute(Cast cast, Script script)
        {
            List<Actor> actors = cast.GetAllActors();
            foreach (Actor actor in actors)
            {
                actor.MoveNext();
            }
        }
    }
}