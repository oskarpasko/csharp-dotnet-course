namespace TwoFilesClass
{
    public abstract class Button
    {   
        public abstract void create();
        public abstract void action();
    }

    public class LoginButton : Button
    {
        private int width;
        private int heigth;
        private string name;

        public LoginButton(int buttonWidth, int buttonHeigth, string buttonName)
        {
            width = buttonWidth;
            heigth = buttonHeigth;
            name = buttonName;
        }
        public override void create()
        {
            Console.WriteLine($"Stworzono przycisk o nazwie {this.name}");
            Console.WriteLine($"Przycisk ma wymiary {this.heigth} x {this.width}");
        }
        public override void action()
        {
            Console.WriteLine("Przycisk loguje uzytkownika");
        }
        
    }

    public class RegisterButton : Button
    {
        private int width;
        private int heigth;
        private string name;

        public RegisterButton(int buttonWidth, int buttonHeigth, string buttonName)
        {
            width = buttonWidth;
            heigth = buttonHeigth;
            name = buttonName;
        }
        public override void create()
        {
            Console.WriteLine($"Stworzono przycisk o nazwie {this.name}");
            Console.WriteLine($"Przycisk ma wymiary {this.heigth} x {this.width}");
        }
        public override void action()
        {
            Console.WriteLine("Przycisk rejestruje uzytkownika");
        } 
    }
}