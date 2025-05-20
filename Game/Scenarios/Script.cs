namespace Game.Scenarios
{

    public class Script
    {
        // Dictionary to hold actions grouped by their type
        private Dictionary<string, List<Action>> _actions = new Dictionary<string, List<Action>>();

        public Script()
        {
        }
        // Method to add an action to a specific group
        // If the group doesn't exist, it creates a new list for that group
        public void AddAction(string group, Action action)
        {
            if (!_actions.ContainsKey(group))
            {
                _actions[group] = new List<Action>();
            }

            if (!_actions[group].Contains(action))
            {
                _actions[group].Add(action);
            }
        }
        // Method to get all actions in a specific group
        // Returns an empty list if the group doesn't exist
        public List<Action> GetActions(string group)
        {
            List<Action> results = new List<Action>();
            if (_actions.ContainsKey(group))
            {
                results.AddRange(_actions[group]);
            }
            return results;
        }
        // Method to remove an action from a specific group
        // If the group exists and contains the action, it removes it from the list
        public void RemoveActor(string group, Action action)
        {
            if (_actions.ContainsKey(group))
            {
                _actions[group].Remove(action);
            }
        }

    }
}