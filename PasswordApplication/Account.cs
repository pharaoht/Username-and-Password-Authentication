using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordApplication
{
    public class Account
    {
        
        Encrypt encrypt = new Encrypt();
        public string username { get; set; }
        public string password { get; set; }

        public static Dictionary<string, string> _account = new Dictionary<string, string>();

        public void UserName()
        {
            try
            {
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Input a username, press enter and then input password");
                _account.Add(username = Console.ReadLine(), password = Console.ReadLine());
               

            }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("That username is taken enter new one");
                UserName();
                
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            var encryptedString = encrypt.EncryptString(key, password);
                Console.WriteLine($"encrypted string = {encryptedString}");
            
        }

        public void ExitCall()
        {
            foreach (KeyValuePair<string, string> z in _account)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("These accounts will be lost forever");
                Console.WriteLine("username: {0}, password = {1}", z.Key, z.Value);
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);

            }
        }

        public void Authenticate()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter your username");
            var userInput = Console.ReadLine();
            Console.WriteLine("enter password");
            var userPasswordInput = Console.ReadLine();
            foreach (KeyValuePair<string, string> z in _account)
            {
                if (userInput  == z.Key && userPasswordInput == z.Value )
                {
                    
                    Console.WriteLine("Hello user {0} your account has been authenticated!", userInput);
                    break;
                }

                if (userInput == z.Key) continue;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("That account does not exist");
                Authenticate();

            }



        }
    }
}
