using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseStringAndSentences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringAndSentences.Tests
{
	[TestClass()]
	public class ReverserTests
	{
		[TestMethod()]
		public void ReverseMeTest()
		{
			Assert.AreEqual("aaasa",Reverser.ReverseMe("asaaa"));
		}

		[TestMethod()]
		public void ReverseEveryWordTest()
		{
			Assert.AreEqual("aaasa ia ma ta", Reverser.ReverseEveryWord("asaaa ai am at"));
		}
	}
}