using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digits
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// ReSharper disable once AssignNullToNotNullAttribute
			var n = int.Parse(Console.ReadLine());
			int digitsSum = 0, factorialSum = 0, count = 0;
			while (n != 0)
			{
				digitsSum += n % 10;
				factorialSum += RecursionFactorial(n % 10);
				count++;
				n /= 10;
			};
			Console.WriteLine(count);
			Console.WriteLine(digitsSum);
			Console.WriteLine(factorialSum);
			Console.ReadLine();
		}

		public static int RecursionFactorial(int n)
		{
			if (n == 1)
			{
				return 1;
			}
			else
			{

				return n * RecursionFactorial(n - 1);

			}
		}
	}
}
