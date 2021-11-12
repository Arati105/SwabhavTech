using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotComFunction
{
	class Program
	{
		static void LocationCells(int[] locs)
		{
			int[] locationCells;
			locationCells = locs;

		}
		static void UserInput(String prompt)
		{
			String inputLine = null;
			Console.WriteLine(prompt + " ");
			try
			{

				inputLine = Console.ReadLine();
				if (inputLine.Length == 0)
				{
					//return null;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("IOException: " + e);
			}
			//return inputLine;
		}
		static void checkYourself(String stringGuess)
		{
			int[] locationsCells = { 2, 3, 4 };
			int numOfHits = 0;

			int guess = int.Parse(stringGuess);
			String result = "miss ";
			foreach (int cell in locationsCells)
			{
				if (guess == cell)
				{
					result = "hit";
					numOfHits++;
					break;
				}
			}
			if (numOfHits == locationsCells.Length)
			{
				result = "kill";
			}
			Console.WriteLine(result);
		// return result;

		}



		static void Main(string[] args)
		{

			int numOfGuesses = 0;
			Program p = new Program();
			Random random = new Random();
			string result;
			int randomNum = random.Next(1, 5);
			int[] locations = { randomNum, randomNum + 1, randomNum + 3 };
			p.LocationCells(locations);
			bool isAlive = true;
			while (isAlive == true)
			{
				String guess = p.UserInput("Enter a number");
				result = p.checkYourself(guess);
				numOfGuesses++;
				if (result.Equals("kill"))
				{
					isAlive = false;
				}
			}
			Console.WriteLine(" You took " + numOfGuesses + " guesses ");
			int[] locations1 = { 2, 3, 4 };
			p.LocationCells(locations1);
			String userGuess = " ";
			result = p.checkYourself(userGuess);
			String testResult = "failed";
			if (result.Equals("hit"))
			{
				testResult = "passed";
			}
			Console.WriteLine(testResult);
		}
		


		}
	}

	