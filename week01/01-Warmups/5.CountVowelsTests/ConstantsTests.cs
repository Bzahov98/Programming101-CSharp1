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
	public class ConstantsTests
	{
		[TestMethod()]

		public void ConstantsCounterTest()
			{
				var countV = new Constants();
				Assert.AreEqual(44, countV.CountConstants("Github is the second best thing that happend to programmers, after the keyboard!"));
			}
	}

}

