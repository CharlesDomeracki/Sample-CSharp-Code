using System;

namespace C_SharpSampleLib
{
	public class Fibonacci
	{
		public static void FibonacciMethod()
		{
			int number, next = 1, previous = -1;
			Console.WriteLine("Enter a maximum number for the Fibonacci sequence: ");
			number = int.Parse(Console.ReadLine());

			for (int i = 0; i < number; i++)
			{
				int iSum = next + previous;
				previous = next;
				next = iSum;
				Console.WriteLine(next);
			}
			// return next;
		}
	}
}