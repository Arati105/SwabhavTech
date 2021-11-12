using SecurityApp.Model;
using System;

namespace SecurityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SecurityServices secure = new SecurityServices();
            secure.AddUser("1001", "Arati", "Khamkar", "aratikhamkar06@gmail.com", "123456");
            secure.AddUser("1002", "Arati", "Khamkar", "aratikhamkar06@gmail.com", "456987");
            secure.Login("1002", "466");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
