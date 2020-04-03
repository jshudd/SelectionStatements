using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Michael's code
            var r = new Random();
            var favNumber = r.Next(1, 1000);

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
                Console.WriteLine($"Never mind");
            }
        }
    }
}
