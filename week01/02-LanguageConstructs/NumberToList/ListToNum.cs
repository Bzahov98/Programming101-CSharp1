using System.Collections.Generic;
using System.Text;

namespace NumList
{
	class ListToNum
	{
		public int ListToNumber(List<int> list)
		 //takes a list of digits and returns the number from those digits
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
