using System;

namespace GuessingGameApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int min = 1;
            int max = 100;
            bool retry = true;
            while (true)
            {
                Console.WriteLine("Game developer by Arati,copyright @ 2021");
                int randomNumber = random.Next(min, max + 1);
                int counter = 1;
                while (true)
                {

                    Console.WriteLine("Guess Number: " + min + "-" + max + " : ");
                    int userGuess = Convert.ToInt32(Console.ReadLine());
                    
                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine(userGuess + " Sorry,Too high");
                        ++counter;
                        continue;
                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine(userGuess + " Sorry,Too low");
                        ++counter;
                        continue;
                       

                    }
                    else
                    {

                        Console.WriteLine("Number: " + randomNumber);
                        Console.WriteLine("Win");
                        Console.WriteLine("guesses:" + counter);
                        Console.WriteLine("Would you like to play again(Y/N) ");
                        string playAgain = Console.ReadLine();
                        
                        Console.WriteLine("Thank your for using my application,pls contact me arati@auripro.com ");

                        if(playAgain!="Y")
                        {
                            retry = false;
                        }
                        break;
                    }

                }
                if (!retry) break;



            }
        }
    }
}







