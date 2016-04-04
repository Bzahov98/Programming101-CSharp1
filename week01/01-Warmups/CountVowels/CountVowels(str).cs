using System.Text.RegularExpressions;

//Vowels in a string

//	Implement a function, called  CountVowels(str) , which returns the count of all vowels in the string str.

//	Count uppercase vowels aswell!

//	The English vowels are  aeiouy.

//	Examples:
//    CountVowels("Python") = 2
//    CountVowels("Theistareykjarbunga") =  8
//    CountVowels("grrrrgh!") = 0
//    CountVowels("Github is the second best thing that happend to programmers, after the keyboard!") = 22
//    CountVowels("A nice day to code!") = 8
namespace CountVowels
{
	public class CounterVowels
	{
		private int _result = 0;

		public int CountVowels(string str)
		{
			
			foreach (var chaR in str)
			{
				if (Regex.IsMatch(chaR.ToString(),"[aeiouy]", RegexOptions.IgnoreCase))
				{
					_result++;
				}
			}
			return _result;
		}
	}
}
