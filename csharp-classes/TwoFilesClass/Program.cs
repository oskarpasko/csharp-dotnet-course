using System;

namespace TwoFilesClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoginButton loginButton = new LoginButton();
            loginButton.create();
            loginButton.action();
        }
    }
}
