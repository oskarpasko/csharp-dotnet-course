using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class LengthUnit : Unit
    {
        private double _value;
        public double Value { get; set; }

        public override void get_value()
        {
            // enter a value to convert
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEnter a value to convert:", Console.ForegroundColor);
            Value = Convert.ToDouble(Console.ReadLine());
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

        public override void write_result(double v, double[] results, string[] resultsUnit, int startUnit)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nResults:", Console.ForegroundColor);
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"\n{v} {resultsUnit[startUnit - 1]} = {results[i]} {resultsUnit[i]}");
            }
        }

        public override void mechanism()
        {
            // create an array with units to output them in results
            string[] unitName = { "mm", "cm", "dm", "m", "km" };

            double[] result;

            int unit_choice = this.get_unit();

            // convert mechanism
            switch (unit_choice)
            {
                case 1: // for mm
                    // create an array with results
                    result = new double[] {(Value), (Value/10),
                    (Value/100), (Value/1000), (Value/10000000)};

                    // output results
                    write_result(Value, result, unitName, unit_choice);
                    break;
                case 2: // for cm
                    // create an array with results
                    result = new double[] {(Value*10), (Value),
                    (Value/10), (Value/100), (Value/1000000)};

                    // output results
                    write_result(Value, result, unitName, unit_choice);
                    break;
                case 3:
                    // create an array with results
                    result = new double[] {(Value*100), (Value*10),
                    (Value), (Value/10), (Value/10000)};

                    // output results
                    write_result(Value, result, unitName, unit_choice);
                    break;
                case 4: // for meter

                    // create an array with results
                    result = new double[]{(Value * 1000), (Value * 100),
                    (Value * 10), Value, (Value / 1000)};

                    // output results
                    write_result(Value, result, unitName, unit_choice);
                    break;
                case 5: // for km
                    // create an array with results
                    result = new double[] {(Value*1000000), (Value*100000),
                    (Value*10000), (Value*1000), (Value)};

                    // output results
                    write_result(Value, result, unitName, unit_choice);
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }
    }

}