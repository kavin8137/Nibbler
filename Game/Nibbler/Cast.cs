namespace Game.Nibbler
{
    public class Cast
    {
        // Dictionary to hold actors categorized by their group names
        private Dictionary<string, List<Actor>> _actors = new Dictionary<string, List<Actor>>();

        public Cast()
        {
        }
        // Method to add an actor to a specific group
        // If the group does not exist, it creates a new list for that group
        public void AddActor(string group, Actor actor)
        {
            if (!_actors.ContainsKey(group))
            {
                _actors[group] = new List<Actor>();
            }

            if (!_actors[group].Contains(actor))
            {
                _actors[group].Add(actor);
            }
        }
        // Method to get all actors in a specific group
        // Returns a list of actors in that group
        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (_actors.ContainsKey(group))
            {
                results.AddRange(_actors[group]);
            }
            return results;
        }
        // Method to get all actors in the cast
        // Returns a list of all actors across all groups
        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in _actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }
        // Method to get the first actor in a specific group
        // Returns the first actor in that group, or null if the group is empty or does not exist
        // Shout out to chatgpt that helped me on debugging this method
        // it tells me that I can use Nullable operature reference
        public Actor? GetFirstActor(string group)
        {
            Actor? result = null;
            if (_actors.ContainsKey(group))
            {
                if (_actors[group].Count > 0)
                {
                    result = _actors[group][0];
                }
            }
            return result;
        }
        // Method to remove an actor from a specific group
        public void RemoveActor(string group, Actor actor)
        {
            if (_actors.ContainsKey(group))
            {
                _actors[group].Remove(actor);
            }
        }

    }
}