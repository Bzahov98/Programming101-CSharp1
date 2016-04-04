using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountVowelsAndConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountVowels;

namespace CountVowelsAndConstants.Tests
{
	[TestClass()]
	public class CountVowelsTests
	{
		[TestMethod()]
		public void CounterVowelsTest()
		{
			var countV = new CounterVowels();

			Assert.AreEqual(22, countV.CountVowels("Github is the second best thing that happend to programmers, after the keyboard!"));
		}
	}
	
	
}