namespace Game.Nibbler
{
    public class Color
    {
        // defining the Color class that represents a color in RGB format
        // this class contains properties for red, green, blue, and alpha values
        public static readonly Color BLACK = new Color(0, 0, 0);
        public static readonly Color WHITE = new Color(255, 255, 255);
        public static readonly Color RED = new Color(255, 0, 0);
        public static readonly Color GREEN = new Color(0, 255, 0);
        public static readonly Color BLUE = new Color(0, 0, 255);
        public static readonly Color YELLOW = new Color(255, 255, 0);
        public static readonly Color CYAN = new Color(0, 255, 255);
        public static readonly Color MAGENTA = new Color(255, 0, 255);
        // defining the properties of the Color class
        // these properties include red, green, blue, and alpha values
        private int _red;
        private int _green;
        private int _blue;
        private int _alpha = 255;
        // defining the constructor for the Color class
        // this constructor initializes the color with red, green, blue, and alpha values
        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }
        // defining the constructor for the Color class with an alpha value
        // this constructor initializes the color with red, green, blue, and alpha values
        public int GetAlpha()
        {
            return _alpha;
        }
        public int GetBlue()
        {
            return _blue;
        }
        public int GetRed()
        {
            return _red;
        }
        public int GetGreen()
        {
            return _green;
        }
    }
}