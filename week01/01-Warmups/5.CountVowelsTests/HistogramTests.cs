using Microsoft.VisualStudio.TestTools.UnitTesting;
using Histogram_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountVowels;

namespace Histogram_.Tests
{
	[TestClass()]
	public class HistogramTests
	{
		[TestMethod()]
		public void CharHistogramTest()
		{
			Dictionary<char, int> expectedDictionary = new Dictionary<char, int>()
			{
			//	expected - 'P': 1, 'y': 1, 't': 1, 'h': 1, 'o': 1, 'n': 1, '!': 2
				{'P', 1},
				{'y', 1},
				{'t', 1},
				{'h', 1},
				{'o', 1},
				{'n', 1},
				{'!', 2},
			};
			/*Dictionary<char, int> resultDictionary = new Dictionary<char, int>() {
				{'P', 1},
				{'y', 1},
				{'t', 1},
				{'h', 1},
				{'o', 1},
				{'n', 1},
				{'!', 2},};
				*/
				Histogram rclass = new Histogram();
				var resultDictionary = rclass.CharHistogram("Phyton!!");
				Assert.AreEqual(true,resultDictionary.All(e => expectedDictionary.Contains(e)));
			/*Assert.AreEqual(resultDictionary,expectedDictionary);
			Histogram rclass = new Histogram();
			//var result = res.CharHistogram("Phyton!!");
			foreach (var exp in expectedDictionary)
			{
				foreach (var res in resultDictionary)
				{
					if (exp.Key == res.Key)
					{
						if (exp.Value != res.Value)
						{
							Assert.Fail("exp.Val= {0} res.Val = {1} ", exp.Value, res.Value);
						}
					}
					else
					{
						Assert.Fail("exp.Key= {0} res.Key = {1} ",exp.Key,res.Key);
					}
				}
			}
			*/
		}
			//Assert.Equals(expectedDictionary,resultDictionary);
	}
}
