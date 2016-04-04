using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_series
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 2, b = 1, c;
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(a);
			Console.WriteLine(b);
			for (int i = 0; i < n - 2; i++)
			{

				c = a + b;
				a = b;
				b = c;
				Console.WriteLine(c);
				//Console.WriteLine( b);
			}
			Console.ReadLine();
		}
	}
}
