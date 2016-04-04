using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extreme_elements
{
	public static class ExtrElmClass
	{
		public static int Min(int[] item)
		//returns the mininum element in items 
		{
			Array.Sort(item);
			foreach (int i in item)
			{
				Console.Write("at min {0} ", i);
			}
			return item[0];
		}

		public static int Max(int[] item)
		//returns the maximum element in items 
		{
			
			Array.Sort(item);
			foreach (int i in item)
			{
				Console.Write("at max {0} ", i);
			}
			var a = (item.Length) - 1;
			return item[a];
		}

		public static int NthMin(int n, int[] item)
		//returns the n-th minimum element in  items 
		{
			Array.Sort(item);
			foreach (int i in item)
			{
				Console.Write("at Nthmin {0} ", i);
			}
			return item[n - 1];
		}

		public static int NthMax(int n, int[] items)
		//- returns the  n th maximum element in  items
		{
			
			Array.Sort(items);
			foreach (int i in items)
			{
				Console.Write("at Nthmin {0} ", i);
			}
			return items[n - 1];
		}


		/*public static int[] Sort(int[] item)
		//sort array
		{
			int[] result = new int[item.Length];
			Array.Copy(item, result, item.Length);
			Array.Sort(result);
			foreach (int i in result)
			{
				Console.Write("{0} ", i);
			}
			//Console.Write("{0}",result);
			return result;
		}*/
	}
}
