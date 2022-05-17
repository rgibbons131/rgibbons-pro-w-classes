using System;
using System.Collections.Generic;

namespace unit02
{
    public class Dealer
    {
        public List<Card> table = new List<Card>();
        public bool isPlaying = true;
        public int totalScore = 300;
        public string guess;
        public Dealer()
        {
            Card card1 = new Card();
            Card card2 = new Card();
            table.Add(card1);
            table.Add(card2);
        }
        public bool getIsPlaying()
        {
            Console.Write("Play again? [y/n]");
            string userPlaying =  Console.ReadLine();
            Console.WriteLine();
            if(userPlaying == "y")
            {
                return true;
            }
            else{return false;}
        }
        public void getGuess()
        {
            Console.Write("Higher or lower? [h/l] ");
            guess =  Console.ReadLine();            
        }
        public void displayCurrentCard(Card card)
        {
            Console.WriteLine($"The card is: {card.faceValue}");
        }
        public void displayNextCard(Card card)
        {
            Console.WriteLine($"The next card was: {card.faceValue}");
        }
        public void displayPoints()
        {
            Console.WriteLine($"Your score is: {totalScore}");
        }
        public bool calculatePoints(Card card1, Card card2, string guess)
        {
            string hilo;
            if(card1.faceValue > card2.faceValue)
            {
                hilo = "l";
            }
            else if(card1.faceValue < card2.faceValue)
            {
                hilo = "h";
            }
            else
            {
                Console.WriteLine("The cards are equal");
                return false;
            }
            if(hilo == guess){totalScore += 100;}
            else{totalScore -= 75;}
            return true;
        }
        public void updateCards()
        {
            table[0].faceValue = table[1].faceValue;
            table[1].drawCard();
        }
        public void startGame()
        {
            while(isPlaying)
            {
                displayCurrentCard(table[0]);
                getGuess();
                displayNextCard(table[1]);
                calculatePoints(table[0],table[1],guess);
                displayPoints();
                isPlaying = getIsPlaying();
                updateCards();
            }
        } 
    }
}
