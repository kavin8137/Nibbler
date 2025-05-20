namespace Game.Nibbler
{
    public class Banner : Actor
    {
        // Constructor to initialize the banner with a specific position, message, and color
        public Banner(int xPos, string message, Color color)
        {  
            SetText(message);
            SetColor(color);
            SetPosition(new Point((xPos * Constants.MAX_X) / 4, 0));
        }
        
    }
}