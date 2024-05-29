using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Hello";
            //int age = 4;

            //Console.WriteLine(name + " Johny, my age is {0}", age);

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Johny";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name");

            string inputName = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Hello {0}", inputName);

            //int correctNumber = 7; 

            Random random = new();
            int correctNumber = random.Next();

            int guess = 0;

            Console.WriteLine("WHat is correct number?");

            while (guess != correctNumber)
            {
                string input = Console.ReadLine() ?? string.Empty;

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("PLease enter a number, not letter");

                    continue;
                }

                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong number. Please try again!");

                    Console.ResetColor();
                }
            }

            Console.WriteLine("Bingo");
        }
    }
}

// commenting shortcut is Ctrl + K + C