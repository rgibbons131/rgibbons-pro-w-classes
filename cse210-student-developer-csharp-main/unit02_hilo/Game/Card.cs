using System;

namespace unit02_hilo
{
    public class Card
    {
        public int faceValue;
        Random rand = new Random();
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
