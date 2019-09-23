using System;

namespace PasswordApplication
{
    public class Account
    {
        private string _userInputUsername;
        private string _userInputPassword;
        public Account()
        {
        }
        public void UserName()
        {
            
            Console.WriteLine("Input Desired Username, then press enter");
            var username = new GenericDictionary<string,string >();
            username.Add(_userInputUsername = Console.ReadLine());
            Console.WriteLine("Input password, then press enter");
            username.Add2(_userInputPassword=Console.ReadLine());

        }
    }
}