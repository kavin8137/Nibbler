namespace Game.Nibbler
{
    // constructing the Snake class that inherits from Actor
    // this class represents the snake in the game
    public class Snake : Actor
    {
        // defining private variables for the snake class
        protected List<Actor> _segments = new List<Actor>();
        private int _index = 0;
        private Color _color;
        private int _player;
        private Color _headColor;
        private Color _bodyColor;
        private Point _position;
        // defining the constructor for the Snake class
        public Snake(int player, Color headColor, Color bodyColor)
        {
            _player = player;
            _headColor = headColor;
            _bodyColor = bodyColor;
            _color = bodyColor;

            if (player == 1)
            {
                _position = new Point(Constants.MAX_X / 4, Constants.MAX_Y / 2);
            }
            else
            {
                _position = new Point(Constants.MAX_X * 3 / 4, Constants.MAX_Y / 2);
            }
            PrepareBody();
        }
        // defining the method to get the position of the snake
        public List<Actor> GetBody()
        {
            return new List<Actor>(_segments.Skip(1).ToArray());
        }
        // defining the method to get the position of the snake
        public Actor GetHead()
        {
            return _segments[0];
        }
        public List<Actor> GetSegments()
        {
            return _segments;
        }
        // definding the method to grow the tail od the snake
        public void GrowTail(int numberOfSegments)
        {
            string bodyText = _segments.Count > 1 ? _segments[1].GetText() : "#";
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = _segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(bodyText);
                segment.SetColor(_color);
                _segments.Add(segment);
            }
        }
        // defining the method that the snake will follow to move
        public override void MoveNext()
        {
            foreach (Actor segment in _segments)
            {
                segment.MoveNext();
            }

            for (int i = _segments.Count - 1; i > 0; i--)
            {
                Actor trailing = _segments[i];
                Actor previous = _segments[i - 1];
                Point velocity = previous.GetVelocity();
                trailing.SetVelocity(velocity);
            }

            this._index += 1;
            if (this._index == Constants.GROWTAIL)
            {
                GrowTail(1);
                _index = 0;
            }
        }
        // defining the method for the snake to turn its head
        // this method is called when the player presses the arrow keys to change the snake's direction
        public void TurnHead(Point direction)
        {
            _segments[0].SetVelocity(direction);
        }
        // defining the method that the snake will follow to prepare its body
        // this method is called when the snake is first created to set its initial position and appearance
        private void PrepareBody()
        {
            int x = _position.GetX();
            int y = _position.GetY();

            for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            {
                Point position = new Point(x, y + i * Constants.CELL_SIZE);
                Point velocity = new Point(0, -1 * Constants.CELL_SIZE);
                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);

                bool isHead = i == 0;

                if (_player == 1)
                {
                    segment.SetText(isHead ? "@" : "#");
                    segment.SetColor(isHead ? _headColor : _bodyColor);
                }
                else if (_player == 2)
                {
                    segment.SetText(isHead ? "B" : "b");
                    segment.SetColor(isHead ? _headColor : _bodyColor);
                }
                _segments.Add(segment);
            }
            _color = _bodyColor;
        }
        // defining the method to change the color of the snake
        // I am first using this method for debugging until I replaced with the assesments
        public void ChangeColor(Color color)
        {
            _color = color;
        }
    }
}