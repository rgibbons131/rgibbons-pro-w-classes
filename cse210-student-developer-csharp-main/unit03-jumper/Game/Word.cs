using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Hider is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Word
    {
        private string word;
        private List<char> hint = new List<char>();

        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Word()
        {
            Random random = new Random();
            word = "apple";
            foreach(char letter in word){
                hint.Add('_');
            }
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public void GetHint(char guess)
        {
            int counter = 0;
            foreach(char letter in word){
                if(guess == letter ){
                    hint[counter] = letter;
                };
                counter++;
            }
            string stringHint = new string(hint.ToArray());
            Console.WriteLine(stringHint);
        }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool CheckGuess(char guess, Jumper jumper)
        {
            foreach(char letter in word){
                if(guess == letter){
                    return true;
                };}
            jumper.LooseLife();
            return false;                
        }
        public bool IsPlaying(){
            foreach(char letter in hint){
                if (letter == '_'){
                    return true;
                }
            }
            return false;
        }
    }
}
