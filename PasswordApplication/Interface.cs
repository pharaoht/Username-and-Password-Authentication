using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordApplication
{
    class Interface
    {
        public Interface()
        {
                
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
        }
    }
}
