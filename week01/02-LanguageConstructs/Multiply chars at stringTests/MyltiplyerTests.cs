using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiply_chars_at_string;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_chars_at_string.Tests
{
	[TestClass()]
	public class MyltiplyerTests
	{
		[TestMethod()]
		public void CopyEveryCharTest()
		{
			var action = Multiplyer.CopyEveryChar("Bulgaria!", 3);
			Assert.AreEqual("BBBuuulllgggaaarrriiiaaa!!!", action);
		}
	}
}