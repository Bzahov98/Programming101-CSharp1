using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{

	public class LargestPalindrome : PalindromScoreClass
	{
		public long GetLargestPalindrome(int n)
		{
			int result=0;
			for (int i = n; i > 0; i--)
			{
				if (IsIntPalindrome(i))
				{
					result = i;
				}
			}
			return result;
		}
	}
}
