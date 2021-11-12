using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Deserialization.Model;
using System.Runtime.Serialization.Formatters.Binary;



namespace Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\\serial.txt";
            FileStream stream = new FileStream(path,FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Deserial d= (Deserial)formatter.Deserialize(stream);
            Console.WriteLine("Id:"+d.Id);
            Console.WriteLine("name:" + d.Name);
            Console.WriteLine("Address:" + d.Address);
            stream.Close();
        }
    }
}
