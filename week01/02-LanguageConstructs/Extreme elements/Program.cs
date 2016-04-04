using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extreme_elements
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
			//ExtrElmClass.Sort(array);
			ExtrElmClass.Min(array);
			Console.WriteLine("MIN: {0}", ExtrElmClass.Min(array));
			Console.WriteLine("MAX: {0}", ExtrElmClass.Max(array));
			Console.ReadLine();
		}
	}
}
