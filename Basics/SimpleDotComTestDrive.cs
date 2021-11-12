using System;

public class SimpleDotComTestDrive
{
	public static void Main(string[] args)
	{
		
		SimpleDotCom dot = new SimpleDotCom();
		int[] locations = new int[] { 2, 3, 4 };
		dot.LocationCells = locations;
		string userGuess = "2";
		string result = dot.checkYourself(userGuess);
	}
}
public class SimpleDotCom
{
	internal int[] locationCells;
	internal int numOfHits = 0;

	public virtual int[] LocationCells
	{
		set
		{
			locationCells = value;
		}
	}
	public virtual string checkYourself(string stringGuess)
	{
		int guess = int.Parse(stringGuess);
		string result = "miss";
		foreach (int cell in locationCells)
		{
			if (guess == cell)
			{
				result = "hit";
				numOfHits++;
				break;
			}
		} 
		if (numOfHits == locationCells.Length)
		{
			result = "kill";
		}
		Console.WriteLine(result);
		return result;
	}
}
