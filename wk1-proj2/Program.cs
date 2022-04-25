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

          if (percent >= 90)
          {
              Console.WriteLine("Your grade is an A");
          }
          else if (percent >= 80)
          {
              Console.WriteLine("Your grade is a B");
          }
          else if (percent >= 70)
          {
              Console.WriteLine("Your grade is a C");
          }
          else
          {
              Console.WriteLine("Your grade is an F");
          }
        }
    }
}