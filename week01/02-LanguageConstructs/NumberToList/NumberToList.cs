using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumList
{
	class NumberAndList
	{
		public List<int> NumberToList(int n)
		//takes an integer and returns a list of its digits
		{
			List<int> list = new List<int>();
			while (n > 0)
			{
				list.Add(n % 10);
				n = n / 10;
			}
			list.Reverse();
			return list;
		}
	}
}
