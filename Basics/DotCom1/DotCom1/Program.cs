using System;
using System.Collections;
using System.Collections.Generic;

namespace DotCom1
{
 class DotCom
	{
		
		private GameHelper helper = new GameHelper();

		private List<DotCom> dotComsList = new List<DotCom>();
		private int numOfGuesses = 0;
		private void setUpGame()
		{
			// first make some dot coms and give them locations
			DotCom one = new DotCom();
			one.Name = "Pets.com";
			DotCom two = new DotCom();
			two.Name = "eToys.com";
			DotCom three = new DotCom();
			three.Name = "Go2.com";
			dotComsList.Add(one);
			dotComsList.Add(two);
			dotComsList.Add(three);
			Console.WriteLine("Your goal is to sink three dot coms.");
			Console.WriteLine("Pets.com, eToys.com, Go2.com");
			Console.WriteLine("Try to sink them all in the fewest number of guesses");

			foreach (DotCom dotComToSet in dotComsList)
			{

				List<string> newLocation = helper.placeDotCom(3);

				dotComToSet.LocationCells = newLocation;

			} 
		} 
		private void startPlaying()
		{

			while (dotComsList.Count > 0)
			{

				string userGuess = helper.getUserInput("Enter a guess");
				checkUserGuess(userGuess);

			} 
			finishGame();
		} 
		static void checkUserGuess(string userGuess)
		{ 
			numOfGuesses++; 
			string result = "miss";
			for (int x = 0; x < dotComsList.Count; x++)
			{
				result = dotComsList[x].checkYourself(userGuess); 
				if (result.Equals("hit")) { break; }
				if (result.Equals("kill"))
				{ 
					dotComsList.Remove(x);
					break; 
				}
			}
			Console.WriteLine(result);
		}
		private void finishGame()
		{
			Console.WriteLine("All Dot Coms are dead! Your stock is now worthless."); if (numOfGuesses <= 18) { Console.WriteLine("It only took you " + numOfGuesses + " guesses."); Console.WriteLine(" You got out before your options sank."); } else { Console.WriteLine("Took you long enough. " + numOfGuesses + " guesses."); Console.WriteLine("Fish are dancing with your options"); }
		}
		public static void main(string[] args)
		{
			DotCom game = new DotCom();
			game.setUpGame();
			game.startPlaying();

		}		
	}
}
	   



	}
	}