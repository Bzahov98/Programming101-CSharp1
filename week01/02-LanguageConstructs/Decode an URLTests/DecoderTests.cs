using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decode_an_URL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_an_URL.Tests
{
	[TestClass()]
	public class DecoderTests
	{
		[TestMethod()]
		public void DecodeUrlTest()
		{
			Decoder dec = new Decoder();
			Assert.AreEqual("k/itten pic.jpg", dec.DecodeUrl("k%2Fitten%20pic.jpg"));
		}
	}
}