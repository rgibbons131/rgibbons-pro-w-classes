namespace unit03_jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Word word = new Word();
        private bool isPlaying = true;
        private Jumper jumper = new Jumper();
        private TerminalService terminalService = new TerminalService();
        private char guess = ' ';

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Moves the seeker to a new location.
        /// </summary>
        private void GetInputs()
        {
            word.PrintHint();
            jumper.PrintParachute();
            guess = char.Parse(terminalService.ReadText("Guess a letter a-z: "));

        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            word.CheckGuess(guess, jumper);
            word.GetHint(guess);
            jumper.UpdateParachute();
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {

            {
                if(!word.IsPlaying()){
                    terminalService.WriteText("You win!");
                    isPlaying = false;
                    word.PrintHint();
                }
                else if(!jumper.IsAlive()){
                    terminalService.WriteText("You loose.");
                    jumper.PrintParachute();
                    isPlaying = false;}
            }
            
        }
    }
}