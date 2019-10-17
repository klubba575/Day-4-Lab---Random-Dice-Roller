using System;

namespace Lab_4_Dice_Rolling
{
	class Program
	{
		static void Main(string[] args)
		{
			bool correctResponse = true;
			while (correctResponse)
			{

				// correctResponse = GamblingTime();
				GamblingTime();
				correctResponse = false;
			}
			
				bool keepGoing = true;
				while (keepGoing)
				{
					GetRandomNumber();
					keepGoing = GetContinue();
				}
				Console.WriteLine("Ok, bye.");
		}
		public static void GamblingTime()
		{
			//input from the user about whether or not they want to play dice
			Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");

			//processing - if y, return true, if n, return false
			//if neither, call GamblingTime recursively

			string diceAnswer = Console.ReadLine();
			if (diceAnswer == "y")
			{
				GetRandomNumber();
			}
			else if (diceAnswer == "n")
			{
				Console.WriteLine("Lady Luck will be missing you!");
			}
			else
			{
				Console.WriteLine("How many drinks have you had tonight?");
			}

		}
		public static void GetRandomNumber()
		{
			Console.WriteLine("How many sides would you like on your dice?");
			int numberSides = int.Parse(Console.ReadLine());
			int max = (numberSides + 1);

			Random random1 = new Random();
			int firstDice = random1.Next(1, max);
			int secondDice = random1.Next(1, max);
			int sum = (firstDice + secondDice);

			if (sum == 12)
			{
				Console.WriteLine($"Roll: {firstDice} {secondDice} Midnight Boxcar!");
			}
			
			else if ((sum == 7) || (sum == 11))
			{
				Console.WriteLine($"Roll: {firstDice} {secondDice} HEY!!! Craps!");
			} 
   
			else if (sum == 2)
			{
				Console.WriteLine($"Roll: {firstDice} {secondDice} Snake Eyes!");
			}
			else
			{
				Console.WriteLine($"Roll: {firstDice} {secondDice} ");
			}
			
		}
		public static bool GetContinue()
		{
			//input from the user on whether or not they want to continue (y/n)
			Console.WriteLine("Would you like to roll again? (y/n)");
			//processing - if y, return true, if n, return false
			//if neither, call GetContinue recursively
			string userInput = Console.ReadLine();

			switch (userInput.ToLower())
			{
				case "y":
					return true;

				case "n":
					return false;

				default:
					return GetContinue();
			}
		}
		
	}
}


