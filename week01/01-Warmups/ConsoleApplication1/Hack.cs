using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumbers
{
	public class Hack
	{
		
		public string ToBinary(int dN)
		{
			string result = string.Empty;
			while (dN > 0)
			{
				var remainder = dN % 2;
				dN /= 2;
				result = remainder + result;

			}
			//int resultInt = Int64.Parse(result);
			return result;
		}
		public bool IsPalindrome(string str)
		{
			int min = 0, max = str.Length - 1;
			while (true)
			{
				if (min > max)
				{
					return true;
				}
				else if (str[min] != str[max])
				{
					return false;
				}
				min++;
				max--;
			}
		}
		public bool SsA(string str)
		{
			int count = 0;

			foreach (char c in str)
			{
				if (c == '1')
					count++;
				//Console.WriteLine(count);
			}
			if (count % 2 == 0) return false;
			else return true;

		}
		public bool IsHack(int n)
		{
			if ((IsPalindrome(ToBinary(n)) && SsA(ToBinary(n))))
			{
				return true;
			}
			else return false;
		}
		public void NextHack(int n)
		{
			if (!IsHack(n))
				Console.WriteLine("IsHack({0})- FALSE", n);
			else
				Console.WriteLine("IsHack({0})- TRUE", n);

			do n++; while (!(IsHack(n)));

			Console.WriteLine("NextHack({0})", n);
		}
	}
}
