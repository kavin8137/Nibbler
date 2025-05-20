namespace Game.Nibbler
{
    // defining the Actor class that represents an actor in the game
    // this class contains properties for text, font size, color, position, and velocity
    public class Actor
    {
        // defining the properties of the Actor class
        // these properties include text, font size, color, position, and velocity
        private string _text = "";
        private int _fontSize = 15;
        private Color _color = Constants.WHITE;
        private Point _position = new Point(0, 0);
        private Point _velocity = new Point(0, 0);
        public Actor()
        {
        }
        // defining the GetColor method that returns the color of the actor
        // this method returns a Color object representing the color of the actor
        public Color GetColor()
        {
            return _color;
        }
        // defining the GetFontSize method that returns the font size of the actor
        // this method returns an integer representing the font size of the actor
        public int GetFontSize()
        {
            return _fontSize;
        }
        // defining the GetPosition method that returns the position of the actor
        // this method returns a Point object representing the position of the actor
        public Point GetPosition()
        {
            return _position;
        }
        // defining the GetText method that returns the text of the actor
        // this method returns a string representing the text of the actor
        public string GetText()
        {
            return _text;
        }
        // defining the GetVelocity method that returns the velocity of the actor
        // this method returns a Point object representing the velocity of the actor
        public Point GetVelocity()
        {
            return _velocity;
        }
        // defining the MoveNext method that updates the position of the actor based on its velocity
        // this method wraps around the screen if the actor goes out of bounds
        public virtual void MoveNext()
        {
            int x = ((_position.GetX() + _velocity.GetX()) + Constants.MAX_X) % Constants.MAX_X;
            int y = ((_position.GetY() + _velocity.GetY()) + Constants.MAX_Y) % Constants.MAX_Y;
            _position = new Point(x, y);
        }
        // defining the Set methods for each property of the Actor class
        // these methods allow setting the values of text, font size, color, position, and velocity
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentNullException("color", "Color cannot be null.");
            }
            this._color = color;
        }
        // defining the SetText method that sets the text of the actor
        // this method throws an exception if the text is null
        public void SetDontSize(int fontSize)
        {
            if (fontSize < 0)
            {
                throw new ArgumentOutOfRangeException("fontSize must be greater than or equal to 0.");
            }
            this._fontSize = fontSize;
        }
        // defining the SetPosition method that sets the position of the actor
        // this method throws an exception if the position is null
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentNullException("Position cannot be null.");
            }
            this._position = position;
        }
        // defining the SetText method that sets the text of the actor
        // this method throws an exception if the text is null
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("Text cannot be null.");
            }
            this._text = text;
        }
        // defining the SetVelocity method that sets the velocity of the actor
        // this method throws an exception if the velocity is null
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentNullException("Velocity cannot be null.");
            }
            this._velocity = velocity;
        }
    }
}