using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountVowels;

namespace CountVowels.Tests
{
	[TestClass()]
	public class PalindromScoreClassTests
	{
		[TestMethod()]
		public void GetLargestPalindromeTest()
		{
			var lp = new LargestPalindrome();
			Assert.IsFalse(1234321 != lp.GetLargestPalindrome(1234322));
		}
	}
}

namespace StringTasks.Tests
{
	[TestClass()]
	public class PalindromScoreClassTests
	{
		[TestMethod()]
		public void IsNumPalindromeTest()
		{
			var psC = new PalindromScoreClass();
			Assert.IsTrue(true == psC.IsStringPalindrome("121"));
		}

		[TestMethod()]
		public void IsIntPalindromeTest1()
		{
			var psC = new PalindromScoreClass();
			Assert.IsTrue(true == psC.IsIntPalindrome(121));
		}

		[TestMethod()]
		public void ReverseNumberTest()
		{

			var psC = new PalindromScoreClass();
			Assert.IsTrue(291 == psC.ReverseNumber(192));//Now wait error
		}

		[TestMethod()]
		public void PScoreTest()
		{
			var psC = new PalindromScoreClass();
			Assert.IsTrue(363 == psC.PScore(132));
		}
	}
}