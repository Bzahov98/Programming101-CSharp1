using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_chars_at_string
{
	public static class Multiplyer
	{
		public static string CopyEveryChar(string input, int k)
		//Copy every character K times

		//Example:  CopyEveryChar("tldr", 3) => "tttllldddrrr"

		{
			var builder = new StringBuilder();
			foreach (var chaR in input)
			{
				for (int i = 0; i < k; i++)
				{
					builder.Append(chaR);
				}
			}
			return builder.ToString();
		}
	}
}
