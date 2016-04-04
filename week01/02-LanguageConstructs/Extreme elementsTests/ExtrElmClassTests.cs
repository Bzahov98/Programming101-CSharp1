using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extreme_elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extreme_elements.Tests
{
	[TestClass()]
	public class ExtrElmClassTests
	{
		[TestMethod()]
		public void MinTest()
					{
			int[] array = new[] {1, 1, 3, 5, 7, 8, 1};
			Assert.AreEqual(1 ,ExtrElmClass.Min(array));

		}

		[TestMethod()]
		public void MaxTest()
		{
			int[] array = new[] { 1, 1, 3, 5, 7, 8, 1 };
			Assert.AreEqual(8, ExtrElmClass.Max(array));
		}

		[TestMethod()]
		public void NthMinTest()
		{
			int[] array = new[] { 1, 1, 3, 5, 7, 8, 1 };
			Assert.AreEqual(1, ExtrElmClass.NthMin(3,array));
		}

		/*[TestMethod()]
		public void SortTest()
		{
			int[] array = new[] { 1, 1, 3, 5, 7, 8, 1};
			int[] array2 = new[]{ 1, 1, 1, 3, 5, 7, 8};
			Assert.AreSame(array2, ExtrElmClass.Sort(array));
		}*/
	}
}