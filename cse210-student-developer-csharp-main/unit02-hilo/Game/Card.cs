using System;

namespace unit02
{
    public class Card
    {
        public int faceValue;
        public Random rand = new Random();
        public Card()
        {
            faceValue = rand.Next(1,14);
        }
        public void drawCard()
        {
            faceValue = rand.Next(1,14);
        }
    }
}
