using System;

namespace soloproject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number to guess under");
            string ValueInText = Console.ReadLine();
            int max = int.Parse(ValueInText);

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, max);
            bool done = false;
            while (done == false)
            {
                Console.WriteLine($"Guess a number between 1 and {max}");
                string GuessText = Console.ReadLine();
                int guess = int.Parse(GuessText);
                if (guess < number)
                {
                    Console.WriteLine("Too Low");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    done = true;
                }
            }
        }
    }
}