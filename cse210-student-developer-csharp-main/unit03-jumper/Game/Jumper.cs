using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    // TODO: Implement the Seeker class as follows...

    // 1) Add the class declaration. Use the following class comment.

        public class Jumper{
            /// <summary>
            /// <para>The person looking for the Hider.</para>
            /// <para>
            /// The responsibility of a Seeker is to keep track of its location.
            /// </para>
            /// </summary>
            //private TerminalService service = new TerminalService();
            //private string guess;
            //private int lives;
            private string parachute;
        
        
        public Jumper()
        {
            /// <summary>
            /// Constructs a new instance of Jumper.
            /// </summary>
            parachute = makeParachute();
            Console.WriteLine(parachute);
            
       }
        private string makeParachute(){
            List<string> parachuteList = new List<string>();
            parachuteList.Add(@"  ___  ");
            parachuteList.Add(@" /___\ ");
            parachuteList.Add(@" \   / ");
            parachuteList.Add(@"  \ /  ");
            parachuteList.Add(@"   O   ");
            parachuteList.Add(@"  /|\  ");
            parachuteList.Add(@"  / \  ");
            parachuteList.Add(@"       ");
            parachuteList.Add(@"^^^^^^^");
            string parachute;
            parachute = string.Join("\n",parachuteList);
            return parachute;
        }
        }
    
}