using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Input grade percentage as an integer");
          string ValueInText = Console.ReadLine();

          int percent = int.Parse(ValueInText);
          
          string letter = "";

          if (percent >= 90)
          {
              letter = "A";
          }
          else if (percent >= 80)
          {
              letter = "B";
          }
          else if (percent >= 70)
          {
              letter = "C";
          }
          else
          {
              letter = "F";
          }
          Console.WriteLine($"Your grade is a(n) {letter}");
        }
    }
}