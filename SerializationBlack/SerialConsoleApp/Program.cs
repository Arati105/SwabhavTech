using Serialization.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerialConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\\serial.txt";
            Serial s = new Serial(101, "Komal", "Pune");
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(stream, s);
            stream.Close();
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine("File saved:" + path);
            Console.ReadLine();   
        }
    }
}
