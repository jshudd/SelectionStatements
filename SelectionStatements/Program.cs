using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Michael's code
            var r = new Random();
            var favNumber = r.Next(0, 1001);

            Console.WriteLine("Guess a number between 0 & 1001.");
            var userInput = int.Parse(Console.ReadLine());
            
            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high.");
            }
            else
            {
                Console.WriteLine("Never mind");
            }
        }
    }
}
