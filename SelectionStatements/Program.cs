﻿using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Michael's code
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);
            
            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is too high! Sorry!");
            }
            else if(guess < number)
            {
                Console.WriteLine("Your guess is too low! Sorry.");
            }
            else
            {
                ConsoleWriteLine("Correct!");

            }
        }
    }
}
