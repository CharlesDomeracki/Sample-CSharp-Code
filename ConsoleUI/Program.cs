using System;
using C_SharpSampleLib;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloWorld.Hello("Charles"));
            Fibonacci.FibonacciMethod();
            FibonacciRecursive.FibonaaciMethod();
            FizzBuzz.FizzBuzzMethod(30);
            Console.WriteLine(ZerosChallenge.ZerosChallengeMethod(1001100000));
        }
    }
}