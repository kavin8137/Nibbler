// importingg necessary namespaces
using Game.Nibbler;

namespace Game.Scenarios
{
    // defining the HandleCollisions class that implements the Action interface
    // this class is responsible for handling collisions between actors in the game
    public class HandleCollisions : Action
    {
        // constructing the variable of _isGameOver to check if the game is over
        private bool _isGameOver = false;
        public HandleCollisions()
        {
        }
        // implementing the Execute method from the Action interface
        // this method is called to check for collisions between actors
        public void Execute(Cast cast, Script script)
        {
            if (_isGameOver == false)
            {
                FoodCollisions(cast);
                SegmentCollisions(cast);
                GameOver(cast);
            }
        }
        // checking for collisions between food and snakes
        // if a snake's head collides with food, the snake grows and the food resets
        private void FoodCollisions(Cast cast)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake")!;
            Snake snake1 = (Snake)cast.GetFirstActor("snake1")!;
            Food food = (Food)cast.GetFirstActor("food")!;
            
            if (snake.GetHead().GetPosition().Equals(food.GetPosition()))
            {
                int points = food.GetPoints();
                snake.GrowTail(points);
                food.Reset();
            }
            else if (snake1.GetHead().GetPosition().Equals(food.GetPosition()))
            {
                int points = food.GetPoints();
                snake1.GrowTail(points);
                food.Reset();
            }
        }
        // checking for collisions between snake segments and the snake's head
        // if a segment collides with the head, the game is over
        private void SegmentCollisions(Cast cast)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake")!;
            Actor head = snake.GetHead();
            List<Actor> body = snake.GetBody();

            Snake snake1 = (Snake)cast.GetFirstActor("snake1")!;
            Actor head1 = snake1.GetHead();
            List<Actor> body1 = snake1.GetBody();

            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head.GetPosition()) || segment.GetPosition().Equals(head1.GetPosition()))
                {
                    _isGameOver = true;
                }
            }

            foreach (Actor segment1 in body1)
            {
                if (segment1.GetPosition().Equals(head1.GetPosition()) || segment1.GetPosition().Equals(head.GetPosition()))
                {
                    _isGameOver = true;
                }
            }
            if (head.GetPosition().Equals(head1.GetPosition()))
            {
                _isGameOver = true;
            }
        }
        // checking if the game is over
        // if the game is over, it sets the _isGameOver variable to true
        public Boolean GetisGameOver()
        {
            return _isGameOver;
        }
        // setting the _isGameOver variable to true
        private void GameOver(Cast cast)
        {
            if (_isGameOver == true)
            {
                Snake snake = (Snake)cast.GetFirstActor("snake")!;
                List<Actor> segments = snake.GetSegments();
                Snake snake1 = (Snake)cast.GetFirstActor("snake1")!;
                List<Actor> segments1 = snake1.GetSegments();
                Food food = (Food)cast.GetFirstActor("food")!;
                Banner banner1 = (Banner)cast.GetFirstActor("banner1")!;
                Banner banner2 = (Banner)cast.GetFirstActor("banner2")!;

                // create a "game over" message
                int x = Constants.MAX_X / 2 - 30;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment in segments)
                {
                    string oldText = segment.GetText();
                    if (oldText == "@")
                    {
                        segment.SetText("X");
                    }
                    else
                    {
                        segment.SetText("x");
                    }
                }
                foreach (Actor segment1 in segments1)
                {
                    string oldText = segment1.GetText();
                    if (oldText == "B")
                    {
                        segment1.SetText("Y");
                    }
                    else
                    {
                        segment1.SetText("y");
                    }
                }
                // change the color of the banners to white
                banner1.SetColor(Constants.WHITE);
                banner2.SetColor(Constants.WHITE);
            }
        }

    }
}