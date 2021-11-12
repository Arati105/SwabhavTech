using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessesGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool play = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (play)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess Number: " + min + "-" + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess:" + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " Sorry,Too high");
                    }
                    else if (guess < number) 
                    {
                        Console.WriteLine(guess + " Sorry,Too low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Win");
                Console.WriteLine("guesses:" + guesses);

                Console.WriteLine("Would you like to play again(Y/N) ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }
            

            Console.WriteLine("Thanks for playing");

            Console.ReadKey();
        }
    }
}
