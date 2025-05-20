// importing necessary namespaces and libraries
using Raylib_cs;
using Game.Nibbler;

namespace Game.Services
{
    public class Video
    {
        // defining private variables for the video class
        private bool _debug = false;
        private Texture2D _snakeHead;
        private Texture2D _snakeBody;
        private Texture2D _snakebHead;
        private Texture2D _snakebBoday;
        private Texture2D _deadHead;
        private Texture2D _deadBody;
        private Texture2D _deadbHead;
        private Texture2D _deadbBody;
        private Texture2D _food;

        // defining the constructor for the video class
        // this constructor takes a boolean parameter to enable or disable debug mode
        public Video(bool debug)
        {
            this._debug = debug;
        }
        public void LoadTexture()
        {
            // loading textures for different game elements
            // these textures are used to represent the snake, food, and other elements in the game
            _snakeHead = Raylib.LoadTexture("Assets/images/snake_head.png");
            _snakeBody = Raylib.LoadTexture("Assets/images/snake_body.png");
            _snakebHead = Raylib.LoadTexture("Assets/images/snake_bhead.png");
            _snakebBoday = Raylib.LoadTexture("Assets/images/snake_bbody.png");
            _deadHead = Raylib.LoadTexture("Assets/images/dead_head.png");
            _deadBody = Raylib.LoadTexture("Assets/images/dead_body.png");
            _deadbHead = Raylib.LoadTexture("Assets/images/dead_bhead.png");
            _deadbBody = Raylib.LoadTexture("Assets/images/dead_bbody.png");
            _food = Raylib.LoadTexture("Assets/images/food.png");
        }
        public void CloseWindow()
        {
            // unloading textures to free up resources
            // this is important to avoid memory leaks and ensure smooth performance
            Raylib.UnloadTexture(_snakeHead);
            Raylib.UnloadTexture(_snakeBody);
            Raylib.UnloadTexture(_deadHead);
            Raylib.UnloadTexture(_deadBody);
            Raylib.UnloadTexture(_food);
            Raylib.CloseWindow();
        }
        public void ClearBuffer()
        {
            // clearing the drawing buffer
            // this is done to prepare for the next frame of drawing
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib_cs.Color.BLACK);
            if (_debug)
            {
                DrawGrid();
            }
        }
        public void DrawActor(Actor actor)
        {
            // drawing the actor on the screen
            var pos = actor.GetPosition();
            int x = pos.GetX();
            int y = pos.GetY();

            string text = actor.GetText();
            // getting the text representation of the actor
            // this text is used to determine which texture to draw
            if (text =="@")
            {
                Raylib.DrawTexture(_snakeHead, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "#")
            {
                Raylib.DrawTexture(_snakeBody, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "B")
            {
                Raylib.DrawTexture(_snakebHead, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "b")
            {
                Raylib.DrawTexture(_snakebBoday, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "*")
            {
                Raylib.DrawTexture(_food, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "X")
            {
                Raylib.DrawTexture(_deadHead, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "x")
            {
                Raylib.DrawTexture(_deadBody, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "Y")
            {
                Raylib.DrawTexture(_deadbHead, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "y")
            {
                Raylib.DrawTexture(_deadbBody, x, y, Raylib_cs.Color.WHITE);
            }
            else if (text == "Game Over!") // Game Over Scene
            {
                int fontSize = actor.GetFontSize();
                Nibbler.Color c = actor.GetColor();
                Raylib_cs.Color color = ToRaylibColor(c);
                Raylib.DrawText(text, x, y, fontSize, color);
            }
            else
            {
                int fontSize = actor.GetFontSize();
                Nibbler.Color c = actor.GetColor();
                Raylib_cs.Color color = ToRaylibColor(c);
                Raylib.DrawText(text, x, y, fontSize, color);
            }
        }
        // this method draws a list of actors on the screen
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }
        // this method draws a single actor on the screen
        public void FlushBuffer()
        {
            Raylib.EndDrawing();
        }
        // this method checks if the window is open
        public bool IsWindowOpen()
        {
            return !Raylib.WindowShouldClose();
        }
        // this method initializes the window
        public void OpenWindow()
        {
            Raylib.InitWindow(Constants.MAX_X, Constants.MAX_Y, Constants.CAPTION);
            Raylib.SetTargetFPS(Constants.FRAME_RATE);
        }
        // this method draws a grid on the screen
        // this grid is used for debugging purposes to visualize the game area
        private void DrawGrid()
        {
            for (int x = 0; x < Constants.MAX_X; x += Constants.CELL_SIZE)
            {
                Raylib.DrawLine(x, 0, x, Constants.MAX_Y, Raylib_cs.Color.GRAY);
            }
            for (int y = 0; y < Constants.MAX_Y; y += Constants.CELL_SIZE)
            {
                Raylib.DrawLine(0, y, Constants.MAX_X, y, Raylib_cs.Color.GRAY);
            }
        }
        // this method converts a Nibbler color to a Raylib color
        // this is necessary because the two libraries use different color representations
        private Raylib_cs.Color ToRaylibColor(Nibbler.Color color)
        {
            int r = color.GetRed();
            int g = color.GetGreen();
            int b = color.GetBlue();
            int a = color.GetAlpha();
            return new Raylib_cs.Color(r, g, b, a);
        }
    }
}
