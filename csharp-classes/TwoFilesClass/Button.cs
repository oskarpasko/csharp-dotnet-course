namespace TwoFilesClass
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
}