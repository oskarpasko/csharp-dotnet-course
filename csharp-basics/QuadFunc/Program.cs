using System;

namespace QuadFunc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic Function");

            // Insert data 
            Console.WriteLine("Insert a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert c");
            double c = Convert.ToDouble(Console.ReadLine());

            // delta
            double delta = (b*b) - 4 * a * c;

            // if delta is negative we're writing it and we're ending program
            if(delta < 0)
            {
                Console.WriteLine("There is no solution. Delta is negative.\nDelta = " + delta);
                Environment.Exit(0);
            }

            // x1
            double x1 = ((b*(-1)) - Math.Sqrt(delta))/(2 * a);

            // if delta equals 0 then we are writing soluton x1
            if(delta == 0)
            {
                Console.WriteLine("There is only one solution.\nx = " + x1);
                Environment.Exit(0);
            }

            double x2 = ((b*(-1)) + Math.Sqrt(delta))/(2 * a);

            Console.WriteLine("There are two solutions.");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}