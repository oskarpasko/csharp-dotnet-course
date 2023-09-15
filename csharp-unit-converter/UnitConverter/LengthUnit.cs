using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
        public class LengthUnit : Unit
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
            // enter a value's unit from what we will convert
                Console.WriteLine("\nWhat unit did You enter the value?");
                Console.WriteLine("1. millimeter (mm)");
                Console.WriteLine("2. centimeter (cm)");
                Console.WriteLine("3. decimeter (dm)");
                Console.WriteLine("4. meter (m)");
                Console.WriteLine("5. kilometer (km)");
                int choice = Convert.ToInt32(Console.ReadLine());

                return choice;
        }

        public override void write_result(double v, double[] results, string[] resultsUnit, int start_unit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nResults:", Console.ForegroundColor);
            for(int i = 0; i<5 ; i++)
            {
                Console.WriteLine($"\n{v} {resultsUnit[start_unit-1]} = {results[i]} {resultsUnit[i]}");
            }
        }

        public override void mechanism()
        {
            // create an array with units to output them in results
            string[] unitName = {"mm", "cm", "dm", "m", "km"};

            double[] result;

            int unit_choice = this.get_unit();
                
            // convert mechanism
            switch(unit_choice)
            {
                case 1: // for mm
                    // create an array with results
                    result = new double[] {(value), (value/10), 
                    (value/100), (value/1000), (value/10000000)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                case 2: // for cm
                    // create an array with results
                    result = new double[] {(value*10), (value), 
                    (value/10), (value/100), (value/1000000)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                case 3:
                    // create an array with results
                    result = new double[] {(value*100), (value*10), 
                    (value), (value/10), (value/10000)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                case 4: // for meter

                    // create an array with results
                    result = new double[]{(value * 1000), (value * 100), 
                    (value * 10), value, (value / 1000)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
                case 5: // for km
                    // create an array with results
                    result = new double[] {(value*1000000), (value*100000), 
                    (value*10000), (value*1000), (value)};
                    
                    // output results
                    write_result(value, result, unitName, unit_choice);
                    break;
            }
        }
    }

}