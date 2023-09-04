using System;

namespace FiboArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("Fibo on arrays");

            // get a fibo's number
            Console.WriteLine("Which Fibo's number You would like to see?");
           int number = Convert.ToInt32(Console.ReadLine());
            
            // creating array for numbers
           int[] fibo = new int[number];

            // calculating number
           for(int i = 2; i < number; i++)
           {
            fibo[0] = 1; 
            fibo[1] = 2;
            fibo[i] = fibo[i-2] + fibo[i-1];
           }

            // output
           Console.WriteLine(number + ". Fibo's number equals " + fibo[number-1]);
        }
    }
}