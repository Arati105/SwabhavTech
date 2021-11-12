using System;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
          
            int min = 1;
            int max = 100;
            int userGuess;
            int systemGeneratedNumber;
            int guessCount;
            String playAgain="Y";

            while (playAgain == "Y")
            {
                userGuess = 0;
                guessCount = 0;
                
                systemGeneratedNumber = random.Next(min, max + 1);
               //Console.WriteLine(systemGeneratedNumber);
                while (userGuess != systemGeneratedNumber)
                {
                    Console.WriteLine("Guess Number: " + min + "-" + max + " : ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess:" + userGuess);

                    if (userGuess > systemGeneratedNumber)
                    {
                        Console.WriteLine(userGuess + " Sorry,Too high");
                    }
                    else if (userGuess < systemGeneratedNumber)
                    {
                        Console.WriteLine(userGuess + " Sorry,Too low");
                    }
                    guessCount++;
                }
                Console.WriteLine("Number: " + systemGeneratedNumber);
                Console.WriteLine("Win");
                Console.WriteLine("guesses:" + guessCount);

                Console.WriteLine("Would you like to play again(Y/N) ");
                playAgain = Console.ReadLine();
                playAgain = playAgain.ToUpper();

               
            }
            Console.WriteLine("Thanks for playing");
            Console.WriteLine();
        }
    }
}
        
    

