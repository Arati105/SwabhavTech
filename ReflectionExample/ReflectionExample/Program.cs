using System;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Type t = typeof(System.String);
             Console.WriteLine(t.Assembly);
            */
            /* Type t = typeof(System.String);
             Console.WriteLine(t.FullName);
             Console.WriteLine(t.BaseType);
             Console.WriteLine(t.IsClass);
             Console.WriteLine(t.IsEnum);
             Console.WriteLine(t.IsInterface);
            */
            //Reflection Print Method
            /* Type t = typeof(System.String);
             Console.WriteLine("Methods of {0} type...", t);
             MethodInfo[] ci = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);
             foreach (MethodInfo m in ci)
             {
                 Console.WriteLine(m);
             }
            */
            //Reflection Print Field

            Type t = typeof(System.String);

            Console.WriteLine("Fields of {0} type...", t);
            FieldInfo[] ci = t.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
            foreach (FieldInfo f in ci)
            {
                Console.WriteLine(f);
            }

        }
    }
}
