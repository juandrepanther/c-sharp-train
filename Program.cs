using System;

namespace NumberGuesser
{
	class Program
	{
		static void Main(string[] args)
		{
			string appName = "Number Guesser";
			string appVersion = "1.0.0";
			string appAuthor = "Johny";

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
			Console.ResetColor();

			Console.WriteLine("What is your name");

			string inputName = Console.ReadLine() ?? string.Empty;
			Console.WriteLine("Hello {0}", inputName);

			// set target number as a random number
			Random random = new();
			int correctNumber = random.Next(1, 10);

			int guess = 0;
			Console.WriteLine("What is correct number? Between 1 and 10");

			while (guess != correctNumber)
			{
				string input = Console.ReadLine() ?? string.Empty;

				// check if input is a number type
				if (!int.TryParse(input, out guess))
				{
					Console.WriteLine("Please enter a number, not a letter");
					continue;
				}

				guess = Int32.Parse(input);

				if (guess != correctNumber)
				{
					Console.WriteLine("Wrong number. Please try again!");
				}
			}

			Console.WriteLine("Bingo");
		}
	}
}

// commenting shortcut is Ctrl + K + C
