using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch(subject)
            {
                case "science":
                    Console.WriteLine("I love Science, too!");
                    break;

                case "math":
                    Console.WriteLine("Ugh, I hate Math!");
                    break;

                case "PE":
                    Console.WriteLine("PE is definitely a lot of fun!");
                    break;

                case "history":
                    Console.WriteLine("History is not too bad.");
                    break;

                case "literature":
                    Console.WriteLine("Lit, huh? I guess you like to read a lot.");
                    break;

                default:
                    Console.WriteLine("Well, you can like whatever you want.");
                    break;

            }
        }
    }
}
