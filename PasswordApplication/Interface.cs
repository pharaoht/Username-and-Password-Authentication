using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace PasswordApplication
{
    class Interface
    {
       private int _userValueForPromptMethod;
        public Interface()
        {
            this.Prompt();
        }
        public void Prompt()
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM");
            Console.WriteLine("");
            Console.WriteLine("Please select one option:"); //add logic to prevent program from crashing
            Console.WriteLine("1. Establish an account ");
            Console.WriteLine("2. Authenticate a user");
            Console.WriteLine("3. Exit the system");
            Console.WriteLine("");
            Console.WriteLine("Enter selection");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------");
            _userValueForPromptMethod = Convert.ToInt32(Console.ReadLine());

            if (_userValueForPromptMethod == 1)
            {
                EstablishAccount();
            }
            else if (_userValueForPromptMethod == 2)
            {
                Authenticate();
            }
            else if (_userValueForPromptMethod == 3)
            {
                Exit();
            }
            else
            { 
                Exit();
            }

        }

        public void EstablishAccount()
        {
            var account = new Account();
            account.UserName();
        }

        public void Authenticate()
        {

        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
