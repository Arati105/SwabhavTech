using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotComApp
{
    class Program
    {
        
        GameHelper helper = new GameHelper();
        List<DotCom> dotcoms = new List<DotCom>();
        int numOfGuesses = 0;
        int DotCom = 0;
        static void setUpGame()
        {
            DotCom one = new DotCom();
            one.setName("Pets.com");
            DotCom two = new DotCom();
            two.setName("eToys.com");
            DotCom three = new DotCom();
            three.setName("Go2.com");
            dotcoms.add(one);
            dotcoms.add(two);
            dotcoms.Add(three);
            Console.WriteLine("your goal is to sink three dot coms.");
            Console.WriteLine("Pets.com,eToys.com,Go2.com");
            Console.WriteLine("Try to sink them all in the fewest number of guesses");
            foreach (DotCom dotcomToSet in dotcoms)
            {
                List<string> newLocation = helper.placeDotCom(3);
                dotcomToSet.setLocationCells(newLocation);
            }
        }
        static void startplaying()
        {
            while (!dotcoms.Count > 0)
            {
                string userGuess = helper.getUserInput("Enter a guess");
                checkUserGuess(userGuess);
            }
        }
        static void checkUserGuess(string userGuess)
        {
            numOfGuesses++;
            string result = "miss";
            for(int x=0;x<dotcoms.Count;x++)
            {
                result = dotcomToSet.checkYourself(userGuess);
                if (result.Equals("hit"))
                {
                    break;
                }
                if(result.Equals("kill"))
                {
                    break;
                }
                
            }
            Console.WriteLine(result);
            
        }
        static void finishGame()
        {
            Console.WriteLine("All Dot Comes are dead! Your stock is now worthless.");
            if(numOfGuesses<=18)
            {
                Console.WriteLine("It only took you " + numOfGuesses + " guesses.");
                Console.WriteLine(" You got out before your options sank.");
            }
            else
            {
                Console.WriteLine("Took you long enough. " + numOfGuesses + " guesses.");
                Console.WriteLine("Fish are dancing with your options");
            }
        }
        public static void main(string[] args)
        {
            Program p = new Program();
            p.setUpGame();
            p.startPlaying();

        }
    }
}


      

        