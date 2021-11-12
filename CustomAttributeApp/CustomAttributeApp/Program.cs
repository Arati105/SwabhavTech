using CustomAttributeApp.Model;
using System;
using System.Linq;
using System.Reflection;

namespace CustomAttributeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAnnotation(typeof(Foo));
        }
        public static void GetAnnotation(Type t)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().Where(T => t.GetCustomAttributes<NeedToRefactor>().Count() >0);

            var method = t.GetMethods().Where(m => m.GetCustomAttributes<NeedToRefactor>().Count() >0);

            Console.WriteLine("Number of Annoted : {0}", method.Count());
            foreach(var m in method)
            {
                Console.WriteLine(m.ReturnType.Name + " " + m.Name);
            }
            Console.ReadLine();
           
        }
    }
}
