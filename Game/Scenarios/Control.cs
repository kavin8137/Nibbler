using Game.Nibbler;
using Game.Services;

namespace Game.Scenarios
{
    // This class is responsible for controlling the actors in the game.
    // It handles the input from the keyboard and updates the direction of the snakes.
    public class ControlActors : Action
    {
        private Keyboard _keyboard;
        private Point _direction = new Point(0, - Constants.CELL_SIZE);
        private Point _direction1 = new Point(0, - Constants.CELL_SIZE);
        public ControlActors(Keyboard keyboardService)
        {
            this._keyboard = keyboardService;
        }

        public void Execute(Cast cast, Script script)
        {
            // left
            if (_keyboard.IsKeyDown("a"))
            {
                _direction = new Point(-Constants.CELL_SIZE, 0);
            }

            // right
            if (_keyboard.IsKeyDown("d"))
            {
                _direction = new Point(Constants.CELL_SIZE, 0);
            }

            // up
            if (_keyboard.IsKeyDown("w"))
            {
                _direction = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if (_keyboard.IsKeyDown("s"))
            {
                _direction = new Point(0, Constants.CELL_SIZE);
            }

            Snake snake = (Snake)cast.GetFirstActor("snake")!;
            snake.TurnHead(_direction);

            // left
            if (_keyboard.IsKeyDown("left"))
            {
                _direction1 = new Point(-Constants.CELL_SIZE, 0);
            }

            // right
            if (_keyboard.IsKeyDown("right"))
            {
                _direction1 = new Point(Constants.CELL_SIZE, 0);
            }

            // up
            if (_keyboard.IsKeyDown("up"))
            {
                _direction1 = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if (_keyboard.IsKeyDown("down"))
            {
                _direction1 = new Point(0, Constants.CELL_SIZE);
            }

            Snake snake1 = (Snake)cast.GetFirstActor("snake1")!;
            snake1.TurnHead(_direction1);
        }
    }
}