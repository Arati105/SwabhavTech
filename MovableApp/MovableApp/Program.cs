using MovableApp.Model;
using System;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables = new IMovable[3];
            movables[0] = new Car();
            movables[1] = new Bike();
            movables[2] = new Truck();
            StartRace(movables);
            Console.ReadLine();
        }
        public static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("Starting the race:");
            foreach(IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}
