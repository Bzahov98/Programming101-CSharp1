using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
	public static class Anagramss
	
		{
		public static bool IsAnagram(string A, string B)
			{
				if (A.Length != B.Length)
					return false;

				return HasAnagramOf(A, B);
			}

			public static bool HasAnagramOf(string A, string B)
			{
				if (A.Length > B.Length)
					return false;

				for (int i = 0; i < A.Length; i++)
				{
					if (B.Contains(A[i]))
					{
						B = B.Remove(B.IndexOf(A[i]), 1);
					}
					else
					{
						return false;
					}
				}

				return true;
			}
		}
	}
