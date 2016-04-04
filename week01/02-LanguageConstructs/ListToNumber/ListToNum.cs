using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToNumber
{
	class ListToNum
	{
		public int ListToNumber(List<int> list)
		{
			StringBuilder StrB = new StringBuilder();
			foreach (var VARIABLE in list)
			{
				StrB.Append(VARIABLE);
			}
			return int.Parse(StrB.ToString());
		}
	}
}
