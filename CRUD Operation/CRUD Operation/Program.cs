using CRUD_Operation.Model;
using System;


namespace CRUD_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStudy1()
        {
            ArrayList1 array = new ArrayList1();
            while (true)
            {
                //Console.WriteLine(" inside Menu:");
                //int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("-----Menu-----");
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Delete");
                    Console.WriteLine("3.Read");
                    Console.WriteLine("4.Update");
                    Console.WriteLine("Make a choice: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            array.Add(num);
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            Console.WriteLine("Enter the input");
                            array.Read();
                            break;

                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            array.Update(num1, num2);
                            break;

                        case 4:
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            array.Delete(num3);
                            break;
                    }
                }
            }

        }
        private static void CaseStudy2()
        {
            Dictionary a = new Dictionary();
            while (true)
            {
                //Console.WriteLine(" inside Menu:");
                //int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("-----Menu-----");
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Delete");
                    Console.WriteLine("3.Read");
                    Console.WriteLine("4.Update");
                    Console.WriteLine("Make a choice: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            int s1 = Convert.ToInt32(Console.ReadLine());
                            a.Create(num, s1);
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            Console.WriteLine(" ");
                            a.Read();
                            break;

                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            a.Update(num1, num2);
                            break;

                        case 4:
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            a.Delete(num3);
                            break;
                    }
                }
            }
        }
        private static void CaseStudy3()
        {
            HashSet1 a = new HashSet1();
            while (true)
            {
                //Console.WriteLine(" inside Menu:");
                //int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    Console.WriteLine("-----Menu-----");
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Delete");
                    Console.WriteLine("3.Read");
                    Console.WriteLine("4.Update");
                    Console.WriteLine("Make a choice: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    switch (input)
                    {
                        case 1:
                            int num = Convert.ToInt32(Console.ReadLine());
                            a.Create(num);
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            Console.WriteLine(" ");
                            a.Read();
                            break;

                        case 3:
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            int num2 = Convert.ToInt32(Console.ReadLine());
                            a.Update(num1, num2);
                            break;

                        case 4:
                            int num3 = Convert.ToInt32(Console.ReadLine());
                            a.Delete(num3);
                            break;
                    }
                }
            }
        }
    }
}
    

    
    

