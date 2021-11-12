using System;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
         
                int firstNo = int.Parse(args[0]);
                int secondNo = int.Parse(args[1]);
                int result = firstNo / secondNo;
                Console.WriteLine("{0}/{1}={2}", firstNo, secondNo, result);
            
            
                Console.WriteLine("End of Main");
            
           
        }
        
        

    }
}

/*ClassName:System.FormatException
 * Lineno=9
 * 
 * className:System.DivideByZeroException
 * LineNo=11
 * 
 * className:System.OverFlowException
 * LineNo=9
 * 
 * 
 */