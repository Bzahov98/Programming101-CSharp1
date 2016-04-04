using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0.Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			{

				int n = int.Parse(Console.ReadLine());
				NonRec Not = new NonRec();
				Console.WriteLine("Without recursion:/n");
				Not.NoRec(n);
				Console.WriteLine("With recursion:/n");
				Console.WriteLine(With.Rec(n));
				Console.ReadLine();

			}
		}
	}
}
