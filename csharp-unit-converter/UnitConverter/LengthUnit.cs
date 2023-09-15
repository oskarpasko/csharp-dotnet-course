using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
        public class LengthUnit : Unit
    {
        private double number;

        public override void get_number()
        {
            // podanie liczbę do przekonwertowania
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nPodaj liczbę do przekonwertowania", Console.ForegroundColor);
                this.number = Convert.ToDouble(Console.ReadLine());
        }

        public override int get_unit()
        {
            // podanie jednostki z której konwertujemy liczbę
                Console.WriteLine("\nW jakiej jednostce podales wartosc?");
                Console.WriteLine("1. mm");
                Console.WriteLine("2. cm");
                Console.WriteLine("3. dm");
                Console.WriteLine("4. m");
                Console.WriteLine("5. km");
                int choice = Convert.ToInt32(Console.ReadLine());

                return choice;
        }

        public override void write_result(double nr, double[] results, string[] resultsUnit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWyniki:", Console.ForegroundColor);
            for(int i = 0; i<5 ; i++)
            {
                Console.WriteLine($"\n{nr} mm = {results[i]} {resultsUnit[i]}");
            }
        }

        public override void mechanism()
        {
            // utworzenie tablicy jednostek do wypisywania ichh w wyniku
            string[] unitName = {"mm", "cm", "dm", "m", "km"};

            double[] result;
                
            // mechanizm konwertowania
            switch(this.get_unit())
            {
                case 1: // dla mm
                    // utworzenie tablice wyników
                    result = new double[] {(number), (number/10), 
                    (number/100), (number/1000), (number/10000000)};
                    
                    // wypisanie wyników
                    write_result(number, result, unitName);
                    break;
                case 2: // dla cm
                    // utworzenie tablice wyników
                    result = new double[] {(number*10), (number), 
                    (number/10), (number/100), (number/1000000)};
                    
                    // wypisanie wyników
                    write_result(number, result, unitName);
                    break;
                case 3:
                    // utworzenie tablice wyników
                    result = new double[] {(number*100), (number*10), 
                    (number), (number/10), (number/10000)};
                    
                    // wypisanie wyników
                    write_result(number, result, unitName);
                    break;
                case 4: // dla metrów

                    // utworzenie tablice wyników
                    result = new double[]{(number * 1000), (number * 100), 
                    (number * 10), number, (number / 1000)};
                    
                    // wypisanie wyników
                    write_result(number, result, unitName);
                    break;
                case 5:
                    // utworzenie tablice wyników
                    result = new double[] {(number*1000000), (number*100000), 
                    (number*10000), (number*1000), (number)};
                    
                    // wypisanie wyników
                    write_result(number, result, unitName);
                    break;
            }
        }
    }

}