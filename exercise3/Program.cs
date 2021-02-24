using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Name: David Piatt
 * Exercise 3
 * 2/19/2021
 * 
 * Comments:
 * It doesn't calculate pi to the exact values in the picture
 * but maybe that's ok. It was fun. I like C# more than Java. 
 * 
 */

namespace exercise3
{
    class Program
    {

        public static double summation(int n)
        {
            double pi = 0;
            for(int i = 0; i <= n; i++)
            {
                double numerator = Math.Pow(-1, i);
                double denominator = ((2 * i) + 1);
                double quotient = numerator / denominator;
                pi += quotient;

                if (i == 10) { Console.WriteLine("At {0:N0} iterations, the value of pi is {1:N10}", i, 4.0*pi); }
                if (i == 1000) { Console.WriteLine("At {0:N0} iterations, the value of pi is {1:N10}", i, 4.0*pi); }
                if (i == 100000) { Console.WriteLine("At {0:N0} iterations, the value of pi is {1:N10}", i, 4.0*pi); }
                if (i == 500000) { Console.WriteLine("At {0:N0} iterations, the value of pi is {1:N10}", i, 4.0*pi); }
                if (i == 1000000) { Console.WriteLine("At {0:N0} iterations, the value of pi is {1:N10}", i, 4.0*pi); }
                if (i == n) { Console.WriteLine("At {0:N0} iterations, the value of pi is {1:N10}", n, 4.0*pi); }

            }
            return 4.0*pi;
        }

        //Must be a number
        //must be > 1000000
        //
        public static bool validation(String s)
        {
            bool isValid = true;
            
            //validate it is not empty
            if(string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Please enter a value > 1 million: ");
                return false;
            }
            //validate it is an intiger
            int num = -1;
            if(!int.TryParse(s, out num))
            {
                Console.WriteLine("Please enter a value > 1 million: ");
                return false;
            }
            
            int n = Convert.ToInt32(s);
            if (n < 1000000)
            {
                Console.WriteLine("Please enter a value > 1 million: ");
                return false;
            }
            
            return isValid;
        }

        static void Main(string[] args)
        {
            double pi = 0.0;
            Console.WriteLine("David's Implementation of the Liebniz Formula:");
            Console.WriteLine("Please enter the number of times to run this calculation");
            String s = Console.ReadLine();
            bool isValid = validation(s);
            while (!isValid)
            {
                s = Console.ReadLine();
                isValid = validation(s);
            }
            int n = Convert.ToInt32(s);
            Console.WriteLine("Iteration: \t Value to 10 decimals:");
            Console.WriteLine();
            //float seed_t = 0.0F;
            pi = summation(n);
            Console.WriteLine("Please hit Enter key to end");
            Console.ReadLine();
        }
    }
}
