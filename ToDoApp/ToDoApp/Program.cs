using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list1 = new List<string>();
            string path = @"E:\SwabhavTech\C#\serialApp.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream,list1);
            Console.WriteLine("*****Welcome to TodoApp*****");
            bool todoLoop = true;
            while (todoLoop)
            {
                Console.WriteLine();
                Console.WriteLine("1.Add new items todos");
                Console.WriteLine("2.display all items todos");
                Console.WriteLine("3.Remove the items");
                Console.WriteLine("4.To exit app");
                Console.Write("\nEnter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    Console.WriteLine("item:");
                    string Item = Console.ReadLine();
                    list1.Add(Item);
                }
                else if (choice == 2)
                {
                  // var list = (List<String>)formatter.Deserialize(stream);
                  //  if (list.Count == 0)
                   // {
                        Console.WriteLine("No item");
                        foreach (var a in list1)
                        {
                            Console.WriteLine(a);
                        }

                    }
                    else if (choice == 3)
                    {
                    
                        Console.WriteLine("item remove");
                   
                        string Item = Console.ReadLine();
                    
                        list1.Remove(Item);
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using app.....");
                        break;
                    }
                }
            //}
            stream.Close();

        }
    }
}


       
    

