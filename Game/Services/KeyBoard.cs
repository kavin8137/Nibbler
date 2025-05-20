// importing libraries
using Raylib_cs;

namespace Game.Services
{
    public class Keyboard
    {
        // Dictionary to map string keys to Raylib keyboard keys
        // This allows us to use string representations of keys in our code
        private Dictionary<string, KeyboardKey> _keys
                = new Dictionary<string, KeyboardKey>();
        // Constructor to initialize the key mappings
        // This maps common string representations of keys to their corresponding Raylib KeyboardKey values
        public Keyboard()
        {
            _keys["w"] = KeyboardKey.KEY_W;
            _keys["a"] = KeyboardKey.KEY_A;
            _keys["s"] = KeyboardKey.KEY_S;
            _keys["d"] = KeyboardKey.KEY_D;
            _keys["left"] = KeyboardKey.KEY_LEFT;
            _keys["right"] = KeyboardKey.KEY_RIGHT;
            _keys["up"] = KeyboardKey.KEY_UP;
            _keys["down"] = KeyboardKey.KEY_DOWN;
        }
        // Method to check if a key is pressed down
        // It takes a string representation of the key as input and returns true if the key is pressed
        public bool IsKeyDown(string key)
        {
            KeyboardKey raylibKey = _keys[key.ToLower()];
            return Raylib.IsKeyDown(raylibKey);
        }
        // Method to check if a key is released
        // It takes a string representation of the key as input and returns true if the key is released
        public bool IsKeyUp(string key)
        {
            KeyboardKey raylibKey = _keys[key.ToLower()];
            return Raylib.IsKeyUp(raylibKey);
        }
    }
}