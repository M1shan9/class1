using System;

namespace Классы
{
    class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users()
            {
                Name = "Михаил",
                Surname = "Асламов",
                Login = "admin",
                Password = "admin",
            };
            Console.WriteLine(user.Name);
            Console.WriteLine("Введите имя");
            user.Name = Console.ReadLine();
            Console.WriteLine($"Ваше новое имя - {user.Name}");
            Console.ReadLine();
        }

        class Users
        {
            public string Name;
            public string Surname;

            public string Login;
            public string Password;
        }
    }
}
