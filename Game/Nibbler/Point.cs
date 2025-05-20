namespace Game.Nibbler
{
    // defining the Point class that represents a point in 2D space
    // this class is used to represent the position of actors in the game
    public class Point
    {
        private int _x = 0;
        private int _y = 0;
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        public Point Add(Point other)
        {
            int x = this._x + other.GetX();
            int y = this._y + other.GetY();
            return new Point(x, y);
        }
        // this method checks if the current point is equal to another point
        // this method is used to check if the snake has eaten the food
        public bool Equals(Point other)
        {
            return this._x == other.GetX() && this._y == other.GetY();
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }
        // this method is used to reverse the direction of the snake when it collides with itself
        public Point Reverse()
        {
            int x = this._x * -1;
            int y = this._y * -1;
            return new Point(x, y);
        }
        // this method is used to scale the point by a given factor
        public Point Scale(int factor)
        {
            int x = this._x * factor;
            int y = this._y * factor;
            return new Point(x, y);
        }
    }
}