using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerialAndDeserial
{
    class Program
    {
        public static void SerializeData()
        {
            string str = "Welcome to Department";
            FileStream fs = new FileStream("E:\\MyDataFile.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, str);
            fs.Close();
        }
        public static void DeSerializeData()
        {
            FileStream fs = new FileStream("E:\\MyDataFile.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string data = " ";
            data = (string)bf.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Your deserialize data is");
            Console.WriteLine(data);
        }
        static void Main(string[] args)
        {
            SerializeData();
            DeSerializeData();
            Console.ReadLine();
        }
    }
}
