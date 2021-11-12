using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SerializationSolutionApp.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\\serial.txt";
           Employee e = new Employee(101,"Komal","Pune");
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(stream, e);
            stream.Close();
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine("File saved:" + path);
            Console.ReadLine();

           /*FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee e = (Employee)formatter.Deserialize(stream);
            Console.WriteLine("Id:" + e.Id);
            Console.WriteLine("Name:" + e.Name);
            Console.WriteLine("Address:" + e.Address);
            stream.Close();*/


        }
    }
}
