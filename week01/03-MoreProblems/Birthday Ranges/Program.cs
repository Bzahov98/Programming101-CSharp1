using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Ranges
{
	class Program
	{
		static void Main(string[] args)
		{
			//{(4, 9), (6, 7), (200, 225), (300, 365)}
			List<KeyValuePair<int, int>> ranges = new List<KeyValuePair<int, int>>();
			//ranges = { (4, 9), (6, 7), (200, 225), (300, 365)}
			
			ranges.Add(new KeyValuePair<int, int>(4, 9));
			ranges.Add(new KeyValuePair<int, int>(6, 7));
			ranges.Add(new KeyValuePair<int, int>(200, 225));
			ranges.Add(new KeyValuePair<int, int>(300, 365));

			List<int> birthdays = new List<int>(){5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15};
			
			foreach (var range in ranges)
			{
				foreach (int index in BirthdayRanges(birthdays, range))
				{
					Console.WriteLine(index);
				}
			}

			//Console.WriteLine("Vector Scalar = {0}", v);
			//Console.WriteLine(ListToNumber(NumberToList(number)));
			Console.ReadLine();
		}
		static List<int> BirthdayRanges(List<int> birthdays, KeyValuePair<int, int> range)
		{
			List<int> result = new List<int>();
			int count = 0;
			foreach (int birth in birthdays)
			{
				if (birth >= range.Key && birth <= range.Value)
				{
					count++;
				}
			}
			result.Add(count);
			return result;
		}
		static List<int> NumberToList(int n)
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
