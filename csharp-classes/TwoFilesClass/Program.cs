using System;

namespace TwoFilesClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoginButton loginButton = new LoginButton(10, 10, "Zaloguj!");
            loginButton.create();
            loginButton.action();
            
            RegisterButton registerButton = new RegisterButton(20, 20, "Zarejestruj sie!");
            registerButton.create();
            registerButton.action();
        }
    }
}
