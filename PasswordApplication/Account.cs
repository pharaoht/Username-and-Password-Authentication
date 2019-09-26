using System;
using System.Collections.Generic;

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
                Console.WriteLine("Input a username, press enter and then input password");
            _account.Add(username = Console.ReadLine(), password = Console.ReadLine());

            }

            catch

            {
                Console.WriteLine("That username is taken enter new one");
                UserName();
            }
            
            
           

        }

    }
}
