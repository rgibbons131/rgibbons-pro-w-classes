using System;
using System.Collections.Generic;

namespace numberProgram
{
    class Program
    {
        static void Main(string[] args)
        {
          List<int> numbers = new List<int>();
          Console.WriteLine("Enter positive integers. Enter 0 when you are done");
          string userInput = "";
          bool done = false;
          int userNumber = 1;
          while (userNumber != 0)
          {
              Console.Write("Enter number: ");
              userInput = Console.ReadLine();
              userNumber = int.Parse(userInput);
              if (userNumber != 0) {numbers.Add(userNumber);}
          }
          int sum = 0;
          float average;
          int largest = 0;
          foreach (int num in numbers)
          {
              sum += num;
              if (num > largest) {largest = num;}
          }
          average = sum / (float)numbers.Count;

          Console.WriteLine($"The sum is {sum}");
          Console.WriteLine($"The average is {average}");
          Console.WriteLine($"The largest number is {largest}");
          Console.WriteLine($"The array is:");
          foreach (int num in numbers) {Console.WriteLine(num);}
        }
    }
}