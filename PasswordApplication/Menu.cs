using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Globalization;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PasswordApplication
{
    class Menu
    {
        private int _userValueForPromptMethod;
        bool Y = true;

        
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
                   Account account = new Account();
                   account.UserName();

               }
               else if(_userValueForPromptMethod == 2)
               {

               }
               else if (_userValueForPromptMethod == 3)
               {
                  Environment.Exit(0);
               }
               else
               {
                   Environment.Exit(0);
               }

               while (true)
               {
                   Console.WriteLine("Do you want to continue? y/n");
                   string x = Console.ReadLine();
                 if (x == "y")
                 {
                     Prompt();
                 }
                 else if (x == "n")
                 {
                    
                    Environment.Exit(0);
                 }
               }
               
           
       }

 
    }
}
