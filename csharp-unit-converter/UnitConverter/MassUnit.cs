using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
        public class MassUnit : Unit
    {
        private double value;

        public override void get_number()
        {
            // enter a value to convert
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nEnter a value to convert:", Console.ForegroundColor);
                this.value = Convert.ToDouble(Console.ReadLine());
        }

        public override int get_unit()
        {
            // enter a number's unit from what we will convert
                Console.WriteLine("\nWhat unit did You enter the value?");
                Console.WriteLine("1. milligram (mg)");
                Console.WriteLine("2. gram (g)");
                Console.WriteLine("3. kilogram (kg)");
                Console.WriteLine("4. tonne (t)");
                int choice = Convert.ToInt32(Console.ReadLine());

                return choice;
        }

        public override void write_result(double v, double[] results, string[] resultsUnit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nResults:", Console.ForegroundColor);
            for(int i = 0; i<4 ; i++)
            {
                Console.WriteLine($"\n{v} mm = {results[i]} {resultsUnit[i]}");
            }
        }

        public override void mechanism()
        {
            // create an array with units to output them in results
            string[] unitName = {"mg", "g", "kg", "t"};

            double[] result;
                
            // convert mechanism
            switch(this.get_unit())
            {
                case 1: // for mg
                    // create an array with results
                    result = new double[] {(value), (value/1000), 
                    (value/1000000), (value/1000000000)};
                    
                    // output results
                    write_result(value, result, unitName);
                    break;
                case 2: // for g
                    // create an array with results
                    result = new double[] {(value*1000), (value), 
                    (value/1000), (value/1000000)};
                    
                    // output results
                    write_result(value, result, unitName);
                    break;
                case 3: // for kg
                    // create an array with results
                    result = new double[] {(value*1000000), (value*1000), 
                    (value), (value/1000)};
                    
                    // output results
                    write_result(value, result, unitName);
                    break;
                case 4: // for tonne

                    // create an array with results
                    result = new double[]{(value * 1000000000), (value * 1000000), 
                    (value * 1000), value};
                    
                    // output results
                    write_result(value, result, unitName);
                    break;
            }
        }
    }

}