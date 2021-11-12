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


            bool turnOver = false;
           bool gameOver = false;
            int playerScores = 0;
            int playerTotal = 0;

            int playerRandmNum;
            int MyRandomNum;
            Console.WriteLine("TURN 1");
            int playerPoints = 0;
            int MyPoints = 0;
            int min = 1;
            int max = 20;
            int dice;
            // bool gameOver = false;

            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Roll or hold?(r/h):");
                Console.ReadLine();
                Console.Write("Die:");
                Console.ReadLine();
                playerRandmNum = random.Next(min, max + 1);
                // Console.WriteLine("You rolled a:" + playerRandmNum);
                MyRandomNum = random.Next(min, max + 1);
                //Console.WriteLine("Eneny AI rolled a:" + enemyRandomNum);
                
                if (playerRandmNum > MyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("");
                }
                else if (playerRandmNum < MyRandomNum)
                {
                    MyPoints++;
                    Console.WriteLine("");
                }

               
                //Console.WriteLine("The scorre is:  " + playerPoints + " Enemy " + enemyPoints);
                //Console.WriteLine();
                dice = random.Next() + 1;
                if (dice == 1)
                {
                    playerScores = 0;
                }
            }
           
            if (playerPoints <  MyPoints)
                {
                Console.WriteLine("Win!");

            }

                else if (playerPoints  > MyPoints)
                {
                Console.WriteLine("Turn over.No score");
                Console.WriteLine("YOu lose!");
                


            }
            
            Console.WriteLine("\nTURN 2");
            int[] dice1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Roll or hold?(r/h):");
                Console.ReadLine();
                Console.Write("Die:");
                Console.ReadLine();
            }
            dice = random.Next() + 1;
            if (dice == 1)
            {
                playerScores = 0;
            }
            
            Console.WriteLine("Roll or hold?(r/h):");
            Console.ReadLine();
            while (turnOver == false || dice != 1)
            //while(true)

            {
                int playerRandmNum1=0;
                int MyRandomNum1=0;                
                playerRandmNum1 = random.Next(min,max);
                MyRandomNum1 = random.Next(min,max);
                playerPoints =MyPoints+playerRandmNum1;
                Console.WriteLine("Score turn:"+playerPoints);
                playerPoints=playerRandmNum1+MyPoints;
                Console.WriteLine("Total score:" +playerPoints);


                if (playerPoints >= 100)
                {
                    Console.WriteLine("Win");
                    gameOver = true;
                }
               

                break;
            }
            Console.WriteLine("\nTURN 3");
            for (int i=0;i<1;i++)
            {

                Console.Write("Roll or hold?(r/h):");
                Console.ReadLine();
                Console.Write("Die:");
                Console.ReadLine();

            }
            Console.Write("Roll or  hold?(r/h):");
            Console.ReadLine();

           
            Console.ReadLine();

            }

        }

    }



    

        

    


