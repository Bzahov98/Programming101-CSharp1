using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringAndSentences
{
	public static class Reverser
	{
		public static string ReverseMe(string original)
		{
			//Implement a function which takes a string
			//and returns the same in a reversed order

			StringBuilder builder = new StringBuilder();
			for (int i = original.Length-1; i >= 0; i--)
			{
				builder.Append(original[i]);
			}
			return builder.ToString();
			//return original.Reverse().ToString();
		}

		public static string ReverseEveryWord(string sentence)
		{
			//Implement a function which takes a string and returns
			//a string which has the same words but each word is in a reverse order.

			string[] str = sentence.Split(' ');
			StringBuilder builder = new StringBuilder();

			foreach (var word in str)
			{
				builder.Append(ReverseMe(word));
				builder.Append(" ");
			}
			var i = sentence.Length;
			builder.Remove(i,1);
			return builder.ToString();
		}

	}
}
