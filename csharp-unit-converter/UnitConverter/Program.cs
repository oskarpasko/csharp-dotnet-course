using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class Application
    {

        public void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====================================", Console.ForegroundColor);
            Console.WriteLine("           Unit Converter");
            Console.WriteLine("====================================");
        }

        public void menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n1. Length Unit", Console.ForegroundColor);
            Console.WriteLine("2. Mass");
            Console.WriteLine("3. Time");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    LengthUnit length = new LengthUnit();
                    length.get_number();
                    length.mechanism();
                    break;
                case 2:
                    MassUnit mass = new MassUnit();
                    mass.get_number();
                    mass.mechanism();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
        public static void Main(string[] args)
        {
            var app = new Application();
            app.welcome();
            while(true)
            {
                app.menu();
            }
        }
    }
}