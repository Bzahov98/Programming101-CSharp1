using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
	class Program
	{
		static void Main(string[] args)
		{
			string inA = Console.ReadLine();
			string inB = Console.ReadLine();
			Console.WriteLine("IsAnagram: {0}", Anagramss.IsAnagram(inA, inB));
			Console.WriteLine("HasAnagram: {0}", Anagramss.HasAnagramOf(inA, inB));
		}
	}
}