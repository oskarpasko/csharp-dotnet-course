using System;

namespace Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Factorial of which number do You would like to calculate?");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of " + number + 
                              " equals" + factorial(number) + ".");
        }

        public static int factorial(int n)
        {
            if (n==1) return 1;
            else return n * factorial(n-1);
        }
    }
}