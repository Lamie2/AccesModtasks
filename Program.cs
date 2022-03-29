using System;

namespace AccessModtask
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine($"Zehmet olmasa istifadeci adinizi daxil edin");
            string username = Console.ReadLine();

            Console.WriteLine($"zehmet olmasa sifrenizi daxil edin");
            string password = Console.ReadLine();

            User user1 = new User(username);
            user1.UserName = username;
            user1.Password = password;
            Console.WriteLine("Username: {user1.UserName}\nPassword: {user1.Password}");
            Console.WriteLine(user1.HasDigit("user")); 
            Console.WriteLine(user1.HasLower("username")); 
            Console.WriteLine(user1.HasUpper("DHGK")); 
        }
    }
}
