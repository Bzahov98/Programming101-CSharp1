using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Factorial
{
	public class With
	{
		public static int Rec(int n)
		{
			if (n == 1)
			{
				return 1;
			}
			else
			{
				return n * Rec(n - 1);
			}
		}
	}
}
