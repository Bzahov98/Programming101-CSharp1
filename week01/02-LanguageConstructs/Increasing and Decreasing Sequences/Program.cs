using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_and_Decreasing_Sequences
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = 4;
			int[] array = new int[size];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("INCREASE {0} ",IncreasingSeq.IsIncreasing(array));
			Console.WriteLine("Decrease {0} ",IncreasingSeq.IsDecreasing(array));
			//Sort(array);
			//Min(array);
			//Console.WriteLine("MIN: {0}", Min(array));
			//Console.WriteLine("MAX: {0}", Max(array));
			//Console.ReadLine();
		}
	}
}
