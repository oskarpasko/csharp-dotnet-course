using System;

namespace FirstClass
{

    public abstract class Button
    {   
        public abstract void create();
        public abstract void action();
    }

    public class LoginButton : Button
    {
        public override void create(){Console.WriteLine("Stworzono przycisk");}
        public override void action(){Console.WriteLine("Zalogowano!");}
        
    }

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
