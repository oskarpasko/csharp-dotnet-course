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
            // enter a value to convert
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nEnter a number to convert:", Console.ForegroundColor);
                this.number = Convert.ToDouble(Console.ReadLine());
        }

        public override int get_unit()
        {
            // enter a number's unit from what we will convert
                Console.WriteLine("\nWhat unit did You enter the value?");
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
            Console.WriteLine("\nResults:", Console.ForegroundColor);
            for(int i = 0; i<5 ; i++)
            {
                Console.WriteLine($"\n{nr} mm = {results[i]} {resultsUnit[i]}");
            }
        }

        public override void mechanism()
        {
            // create an array with units to output them in results
            string[] unitName = {"mm", "cm", "dm", "m", "km"};

            double[] result;
                
            // convert mechanism
            switch(this.get_unit())
            {
                case 1: // for mm
                    // create an array with results
                    result = new double[] {(number), (number/10), 
                    (number/100), (number/1000), (number/10000000)};
                    
                    // output results
                    write_result(number, result, unitName);
                    break;
                case 2: // for cm
                    // create an array with results
                    result = new double[] {(number*10), (number), 
                    (number/10), (number/100), (number/1000000)};
                    
                    // output results
                    write_result(number, result, unitName);
                    break;
                case 3:
                    // create an array with results
                    result = new double[] {(number*100), (number*10), 
                    (number), (number/10), (number/10000)};
                    
                    // output results
                    write_result(number, result, unitName);
                    break;
                case 4: // for meter

                    // create an array with results
                    result = new double[]{(number * 1000), (number * 100), 
                    (number * 10), number, (number / 1000)};
                    
                    // output results
                    write_result(number, result, unitName);
                    break;
                case 5: // for km
                    // create an array with results
                    result = new double[] {(number*1000000), (number*100000), 
                    (number*10000), (number*1000), (number)};
                    
                    // output results
                    write_result(number, result, unitName);
                    break;
            }
        }
    }

}