using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumbers
{
	//Working but need to make tests
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			//ToBinary(decimalNumber);
			//Console.WriteLine(ToBinary(decimalNumber));
			//Console.WriteLine(IsPalindrome(ToBinary(decimalNumber)));
			//Console.WriteLine(SsA(ToBinary(decimalNumber)));
			Hack HackNumber = new Hack();
			HackNumber.IsHack(number);
			HackNumber.NextHack(number);
			Console.ReadLine();

		}
	}
}
