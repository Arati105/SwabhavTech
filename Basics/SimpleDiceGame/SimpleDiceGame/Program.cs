using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandmNum;
            int MyRandomNum;
            Console.WriteLine("TURN 1");
            int playerPoints = 0;
            int MyPoints = 0;
            int min = 1;
            int max = 20;
            Random random = new Random();
         
            for (int i = 0; i < 4; i++)
            {
                 Console.Write("Roll or hold?(r/h):");
                Console.ReadLine();
                Console.Write("Die:");
                Console.ReadLine();
                playerRandmNum = random.Next(min,max+1);
               // Console.WriteLine("You rolled a:" + playerRandmNum);
                MyRandomNum = random.Next(min,max+1);
                //Console.WriteLine("Eneny AI rolled a:" + enemyRandomNum);

                if(playerRandmNum > MyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("");
                }
                else if(playerRandmNum < MyRandomNum)
                {
                    MyPoints++;
                    Console.WriteLine("");
                }
                
                //Console.WriteLine("The scorre is:  " + playerPoints + " Enemy " + enemyPoints);
                //Console.WriteLine();

            }
            if(playerPoints > MyPoints)
            {
                Console.WriteLine("YOu Win!");
            }
            else if(playerPoints < MyPoints)
            {
                Console.WriteLine("Turn over.No score");
                Console.WriteLine("You lose!");
            }
           
            Console.ReadLine();

        }

    }
    
}
