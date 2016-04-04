using System.Text.RegularExpressions;

namespace CountVowels
//Implement a function, called  CountConsonants(str) , which returns the count of all consonants in the string str.

//Count uppercase consonants as well!

//The English consonants are  bcdfghjklmnpqrstvwxz.

{
	public class Constants
	{
		private int _result = 0;
		
		public int CountConstants(string str)
		{

			foreach (var chaR in str)
			{
				if (Regex.IsMatch(chaR.ToString(), "([bcdfghjklmnpqrstvwxz])",RegexOptions.IgnoreCase))
				{
					_result++;
				}
			}
			return _result;
		}
	}
}