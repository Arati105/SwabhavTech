using System;

namespace ThrowException
{
    class Program
    {
       static void Main(string[] args)
        {
            int num1, num2, result;

            
            num1 = int.Parse(args[0]);
            num2 = int.Parse(args[1]);
          

            try
            {
                if (num2 == 0)
                {
                    throw new Exception("Can't Divide by Zero Exception\n\n");
                }
                result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            Console.ReadLine();

        }
    }
}

/*
 * classname:-System.FormatException
 * Lineno:-14
 * 
 * classname:- System.OverflowException: Value was either too large or too small for an Int32.
 * Lineno:-14
 * 
 * classname:- System.IndexOutOfRangeException
 * Lineno:-15
 * 
*/