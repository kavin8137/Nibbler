// importing necessary namespaces for the game
using Game.Nibbler;

namespace Game
{
    // defining the Constants class that contains constant values used in the game
    // this class includes color constants, screen dimensions, cell size, frame rate, font size, and game settings
    public class Constants
    {
        // defining color constants using the Color class
        // these constants represent common colors used in the game
        public static readonly Color BLACK = new Color(0, 0, 0);
        public static readonly Color WHITE = new Color(255, 255, 255);
        public static readonly Color RED = new Color(255, 0, 0);
        public static readonly Color GREEN = new Color(0, 255, 0);
        public static readonly Color BLUE = new Color(0, 0, 255);
        public static readonly Color YELLOW = new Color(255, 255, 0);
        public static readonly Color CYAN = new Color(0, 255, 255);
        public static readonly Color MAGENTA = new Color(255, 0, 255);
        
        // defining screen dimensions
        // these constants represent the maximum width and height of the game window
        public const int MAX_X = 900;
        public const int MAX_Y = 600;
        public static int CELL_SIZE = 15;
        public static int COLUMNS = 40;
        public static int ROWS = 20;
        public static int FRAME_RATE = 15;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Nibbler";
        public static int SNAKE_LENGTH = 8;
        public static int GROWTAIL = 30;
    }
}