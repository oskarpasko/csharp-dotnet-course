using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
        public class TimeUnit : Unit
    {
        private double value;

        public override void get_value()
        {
            // enter a value to convert
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nEnter a value to convert:", Console.ForegroundColor);
                this.value = Convert.ToDouble(Console.ReadLine());
        }

        public override int get_unit()
        {
            // enter a value's unit from what we will convert
                Console.WriteLine("\nWhat unit did You enter the value?");
                Console.WriteLine("1. second (s)");
                Console.WriteLine("2. minute (m)");
                Console.WriteLine("3. hour (h)");
                Console.WriteLine("4. day");
                int choice = Convert.ToInt32(Console.ReadLine());

                return choice;
        }

        public override void write_result(double v, double[] results, string[] resultsUnit, int startUnit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nResults:", Console.ForegroundColor);
            for(int i = 0; i<results.Length ; i++)
            {
                Console.WriteLine($"\n{v} {resultsUnit[startUnit-1]} = {results[i]} {resultsUnit[i]}");
            }
        }

        public override void mechanism()
        {
            // create an array with units to output them in results
            string[] unitName = {"s", "m", "h", "day"};

            double[] result;

            int unit_choice = this.get_unit();
                
            // convert mechanism
            switch(unit_choice)
            {
                case 1: // for a second
                    // create an array with results
                    result = new double[] {(value), (value/60), 
                    (value/3600), (value/86400)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                case 2: // for a minute
                    // create an array with results
                    result = new double[] {(value*60), (value), 
                    (value/60), (value/1440)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                case 3: // for an hour
                    // create an array with results
                    result = new double[] {(value*3600), (value*60), 
                    (value), (value/24)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                case 4: // for a day

                    // create an array with results
                    result = new double[]{(value * 86400), (value * 1440), 
                    (value * 24), value};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }
    }

}