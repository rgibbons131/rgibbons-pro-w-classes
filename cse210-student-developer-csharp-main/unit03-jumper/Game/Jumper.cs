using System;
using System.Collections.Generic;


namespace unit03_jumper
{
        public class Jumper{
            /// <summary>
            /// <para>The person looking for the Hider.</para>
            /// <para>
            /// The responsibility of a Seeker is to keep track of its location.
            /// </para>
            /// </summary>
            //private TerminalService service = new TerminalService();
            //private string guess;
            private int lives;
            private string parachute;        
        public Jumper()
        {
            /// <summary>
            /// Constructs a new instance of Jumper.
            /// </summary>
            parachute = MakeParachute();
            lives = 4;            
       }
        public int LooseLife(){
            lives -= 1;
            return lives;
        }
        private string MakeParachute(){
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
        public void UpdateParachute(){
            List<string> parachuteList = new List<string>();
            if (lives == 4){
            parachuteList.Add(@"  ___  ");
            parachuteList.Add(@" /___\ ");
            parachuteList.Add(@" \   / ");
            parachuteList.Add(@"  \ /  ");
            parachuteList.Add(@"   O   ");
            parachuteList.Add(@"  /|\  ");
            parachuteList.Add(@"  / \  ");
            parachuteList.Add(@"       ");
            parachuteList.Add(@"^^^^^^^");
            parachute = string.Join("\n",parachuteList);
            }
            else if (lives == 3){
            parachuteList.Add(@" /___\ ");
            parachuteList.Add(@" \   / ");
            parachuteList.Add(@"  \ /  ");
            parachuteList.Add(@"   O   ");
            parachuteList.Add(@"  /|\  ");
            parachuteList.Add(@"  / \  ");
            parachuteList.Add(@"       ");
            parachuteList.Add(@"^^^^^^^");
            parachute = string.Join("\n",parachuteList);
            }
            else if (lives == 2){
            parachuteList.Add(@" \   / ");
            parachuteList.Add(@"  \ /  ");
            parachuteList.Add(@"   O   ");
            parachuteList.Add(@"  /|\  ");
            parachuteList.Add(@"  / \  ");
            parachuteList.Add(@"       ");
            parachuteList.Add(@"^^^^^^^");
            parachute = string.Join("\n",parachuteList);
            }
            else if (lives == 1){
            parachuteList.Add(@"  \ /  ");
            parachuteList.Add(@"   O   ");
            parachuteList.Add(@"  /|\  ");
            parachuteList.Add(@"  / \  ");
            parachuteList.Add(@"       ");
            parachuteList.Add(@"^^^^^^^");
            parachute = string.Join("\n",parachuteList);
            }
            else{
            parachuteList.Add(@"   X   ");
            parachuteList.Add(@"  /|\  ");
            parachuteList.Add(@"  / \  ");
            parachuteList.Add(@"^^^^^^^");
            parachute = string.Join("\n",parachuteList);
            }
        }
        public bool IsAlive(){
            if (lives <= 0){
                return false;
            }
            else{return true;}
        }
        public void PrintParachute(){
            Console.WriteLine();
            Console.WriteLine(parachute);
        }
    }    
}