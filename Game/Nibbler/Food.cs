namespace Game.Nibbler
{
    // defining the Food class that inherits from the Actor class
    // this class represents the food in the game
    public class Food : Actor
    {
        // defining private variables for the Food class
        // _points variable to store the points for the food
        private int _points = 0;

        public Food()
        {
            SetText("*");
            SetColor(Constants.RED); 
            Reset();
        }
        // defining the method to get the points for the food
        // this method returns the points for the food
        public int GetPoints()
        {
            return _points;
        }
        // this method resets the food position and points
        // this method is called when the food is eaten by the snake
        public void Reset()
        {
            Random random = new Random();
            _points = random.Next(1,3);
            int x = random.Next(Constants.COLUMNS);
            int y = random.Next(Constants.ROWS);
            Point position = new Point(x, y);
            position = position.Scale(Constants.CELL_SIZE);
            SetPosition(position);
        }
    }
}