using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Factorial
{
	public class NonRec
	{
		int b;
		public void NoRec(int n)
		{
			b = 1;
			for (var i = 1; i <= n; i++)
			{
				b = b * i;
				
			}
			Console.WriteLine(b);
		}
	}
}
