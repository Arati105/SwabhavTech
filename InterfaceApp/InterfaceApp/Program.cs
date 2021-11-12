using InterfaceApp.Model;
using System;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man();
            Boy b = new Boy();
            AtThePartyHall(m);
            AtThePartyHall(b);
            AtTheCinemaHall((IEmotion)m);//Compileration error
            AtTheCinemaHall(b);
            
        }
        private static void AtThePartyHall(IManner obj)
        {
            Console.WriteLine("At the Party");
            obj.Wish();
            obj.Depart();

        }
        private static void AtTheCinemaHall(IEmotion obj)
        {
            Console.WriteLine("At  the Cinema Hall");
            obj.Cry();
            obj.Laught();
        }
    }
}
