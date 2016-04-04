using System.Linq;
//Palindrome Score

//We denote the "Palindrome score" of an integer by the following function:
//• P(n) = 1 , if  n  is palindrome
//• P(n) = 1 + P(s) where s  is the sum of  n  and the  reverse of n

//Implement a function, called  PScore(n) , which finds the palindrome score for n.

//Lets see two examples:
//• PScore(121) = 1 , because  121  is a palindrome.

//• PScore(48) = 3 , because: 

//1. P(48) = 1 + P(48 + 84) = 132 
//2. P(132) = 1 + 1 + P(132 + 321 = 363) 

namespace CountVowels
{
	public class PalindromScoreClass
	{
		public bool IsStringPalindrome(string str)
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

		public bool IsIntPalindrome(int input)
		{
			return input + ReverseNumber(input) == input * 2;
		}

		public int ReverseNumber(int n)
		{
			return n.ToString().Reverse().Aggregate(0, (b, x) => 10*b + x - '0');
		}

		public int PScore(int n)
		{
			if (IsIntPalindrome(n))
			{
				return 1;
			}	
			else
			{
				return 1 + PScore(ReverseNumber(n));
			}
		}
	}
}
