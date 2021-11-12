using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePig
{
   public class Program
    {
        static void Main(string[] args)
        {
			Random rand = new Random();
			

			int TotalScore = 0;
			//int STotalScore = 0;
			int SubTotal = 0;
			bool run = true;
			int roll = 0;

			do
			{
				Console.WriteLine("**********Turn 1************");
				Console.Write("Roll or hold?(r/h): ");
				Console.ReadLine();
				run = true;
				do
				{
					roll = 1 + rand.Next(6);
					Console.Write("\n Die: " + roll + ".");
					Console.ReadLine();
					Console.Write("\nRoll or hold?(r/h): ");
					Console.ReadLine();



					if (roll == 1)
					{
						Console.Write("Turn over.No score");
						Console.WriteLine("\nscore : " +TotalScore);
						Console.WriteLine("\nTotal score: " + TotalScore);
						run = false;
					}
					else
					{
						TotalScore += roll;
						Console.Write(" score: " + TotalScore);
						Console.Write( " \nTotal  score: " + TotalScore);
						if (TotalScore >= 20)
						{
							run = false;
						}
						else
						{
							
							//Console.WriteLine("Roll or hold?(r/h): ");
						
							/*if (response.Equals("h", StringComparison))
							{
								run = false;

							}*/
						}
					}

				} while (run);
				
				//Console.WriteLine("No Score");

				if (TotalScore < 20)
				{
					Console.WriteLine("\n***********Turn2**********");
					

					SubTotal = 0;
					run = true;
					do
					{
						roll = 1 + rand.Next(6);
						Console.WriteLine("\nDie " + roll + ".");
						Console.Write("Roll or hold?(r/h):");
						Console.ReadLine();


						if (roll == 1)
						{
							Console.WriteLine("\nscore: " + TotalScore);
							Console.WriteLine( "\nTotal score: " + TotalScore);
							run = false;
						}

						else
						{
							//System.out.print("Roll or hold?(r/h): ");
							SubTotal += roll;
							TotalScore += roll;
							Console.WriteLine("\nscore: " + TotalScore);
							Console.WriteLine("\nTotal score: " + TotalScore);

							if (SubTotal >= 20)
							{
								//Console.WriteLine("subtotal >= 20.");
								run = false;
							}

							if (TotalScore >= 20)
							{
								run = false;
							}
						}

					} while (run && SubTotal < 20);

				}
				Console.WriteLine();
			} while (TotalScore < 1 && TotalScore < 20);

			if (TotalScore >= 20)
			{
				Console.WriteLine(" Win the game!");
			}
			else
			{
				Console.WriteLine("Congulations game over!");
			}

			

		}
	}

}
    


