using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PasswordApplication
{
    public class Account
    {
 
        public string username { get; set; }
        public string password { get; set; }

       static Dictionary<string, string> _account = new Dictionary<string, string>();

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

        }

        public void ExitCall()
        {        
            foreach (KeyValuePair<string,string> z in _account)
            {
                Console.WriteLine("username: {0}, Value = {1}", z.Key, z.Value);
            }
        }

        public void Authenticate()
        {

        }
    }
}
