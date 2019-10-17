using System;

namespace Lab_4_Dice_Rolling
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
			string diceAnswer = Console.ReadLine();
			if (diceAnswer == "y")
			{
				Console.WriteLine("How many sides would you like on your dice?");
				int numberSides = int.Parse(Console.ReadLine());
				int max = (numberSides + 1);

				Random random1 = new Random();
				bool keepGoing = true;
				while (keepGoing) 
				{
					Console.WriteLine("Roll :");
					Console.WriteLine($" " + random1.Next(1, max));
					Console.WriteLine($" " + random1.Next(1, max));
					//what up tho?

					//Do you want to continue?
					keepGoing = GetContinue();
				}
				Console.WriteLine("Ok, bye.");
			} 
			else 
			{
				Console.WriteLine("That is all the fun for today.");
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


