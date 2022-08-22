using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpSampleLib
{
    public class FibonacciRecursive 
    {
        public static int FindFibonacci(int n)
        {
            int p = 0;
            int q = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = p;
                p = q;
                q = temp + q;
            }
            return p;
        }

        public static void FibonaaciMethod()
        {
            Console.Write(" Input number of terms for the Fibonacci series : ");
            int n1 = Convert.ToInt32(Console.ReadLine());   // Convert string to an integer using ToInt32 method
            Console.Write("\n The Fibonacci series of {0} terms is : ", n1);  // {0} insert first parameter from the ReadLine()
            for (int i = 0; i < n1; i++)
            {
                Console.Write("{0}  ", FindFibonacci(i));
            }
            Console.ReadKey();
        }
    }

}