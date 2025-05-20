// importing namespaces
using Game.Nibbler;

namespace Game.Scenarios
{
    // defining the Action interface
    // this interface will be implemented by different action classes
    public interface Action
    {
        // defining the Execute method that takes a Cast and Script as parameters
        // this method will be responsible for executing the action
        void Execute(Cast cast, Script script);
    }
}