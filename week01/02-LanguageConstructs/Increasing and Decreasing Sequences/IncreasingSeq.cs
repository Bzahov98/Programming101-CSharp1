using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_and_Decreasing_Sequences
{
	public static class IncreasingSeq
	{
		public static bool IsIncreasing(int[] sequence)
		{
			for (int i = 0; i < sequence.Length - 2; i++)
			{
				if (!(sequence[i] > sequence[i + 1]))
				{
					return false;
				}
			}
			return true;
		}
		public static bool IsDecreasing(int[] seq)
		{
			for (int i = 0; i < seq.Length - 2; i++)
			{
				if (!(seq[i] > seq[i + 1]))
				{
					return false;
				}
			}
			return true;
		}

	}
}
