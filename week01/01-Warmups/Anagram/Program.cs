using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
	public class Program
	{
		
		public static bool IsAnagram(string a, string b)
		{
			Dictionary<char, int> dictionary1 = new Dictionary<char, int>();
			foreach (var chaR in a)
			{
				if (dictionary1.ContainsKey(chaR))
				{
					dictionary1[chaR] += 1;
				}
				else
				{
					dictionary1.Add(chaR, 1);
				}
			}

			Dictionary<char, int> dictionary2 = new Dictionary<char, int>();
			foreach (var chaR in b)
			{
				if (dictionary2.ContainsKey(chaR))
				{
					dictionary2[chaR] += 1;
				}
				else
				{
					dictionary2.Add(chaR, 1);
				}
			}

			bool isEqual = dictionary1.OrderBy(r => r.Key).SequenceEqual(dictionary2.OrderBy(r => r.Key));
			return isEqual;
		}

		/// <summary>
		/// Main function.
		/// </summary>
		public static void Main()
		{
			string firstString = Console.ReadLine();
			string secondstring = Console.ReadLine();
			Console.WriteLine("first String {0} and Second string {1} are anagrams {2} ", firstString, secondstring, IsAnagram(firstString, secondstring));
		}
	}

}
