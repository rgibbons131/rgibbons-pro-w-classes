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
        private List<string> hint = new List<string>();

        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Word()
        {
            Random random = new Random();
            word = "apple";
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            string hint = "_ _ _ _ _";


            return hint;
        }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
//        public bool IsFound()
//        {
//            
//        }
    }
}