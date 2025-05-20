// importing necessary namespaces
using Game.Nibbler;
using Game.Services;

namespace Game.Scenarios
{
    // defining the DrawActors class that implements the Action interface
    public class DrawActors : Action
    {
        // defining a private variable for the video service
        private Video _video;
        public DrawActors(Video video)
        {
            this._video = video;
        }
        // defining the method that will draw the actors on the screen
        public void Execute(Cast cast, Script script)
        {
            // shoutout to chat gpt for the help with the 
            // null-forgiving operator references when I was 
            // debugging this code!
            Snake snake = (Snake)cast.GetFirstActor("snake")!;
            List<Actor> segments = snake.GetSegments();
            Snake snake1 = (Snake)cast.GetFirstActor("snake1")!;
            List<Actor> segments1 = snake1.GetSegments();
            Actor banner1 = cast.GetFirstActor("banner1")!;
            Actor banner2 = cast.GetFirstActor("banner2")!;
            Actor food = cast.GetFirstActor("food")!;
            List<Actor> messages = cast.GetActors("messages");

            // drawing the actors on the screen
            _video.DrawActors(segments);
            _video.DrawActors(segments1);
            _video.DrawActor(food);
            _video.DrawActor(banner1);
            _video.DrawActor(banner2);
            _video.DrawActors(messages);
            _video.FlushBuffer();
            _video.ClearBuffer();
        }
    }
}