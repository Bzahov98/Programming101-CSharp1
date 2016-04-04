using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTransversal
{
	class Program
	{
//		Transversal

//Lets have a set of sets:

// A = { {1, 2, 3} , {4, 5, 6}, {7, 8, 9} } 

//A transversal  T  for  A  is a set that contains at least one element from each set of  A.

//For example:  T = {1, 4, 7} 

//Implement a function bool IsTransversal(List<int> transversal, List<List<int>> family) , which checks if given set is a valid  transerval  for another family  of sets(set of sets).

//Examples:
//>>> IsTransversal({ 4, 5, 6}, {{5, 7, 9}, {1, 4, 3}, {2, 6}}))
//true
//>>> IsTransversal({ 1, 2}, {{1, 5}, {2, 3}, {4, 7}})
//false


		static void Main(string[] args)
		{
			List<int> testList = new List<int>() {4,5,6};
			List<List<int>> testColection = new List<List<int>>();
			List<int> a = new List<int>() { 5, 7, 9 };
			testColection.Add(a);
			List<int> b = new List<int>() { 1, 5, 3 };
			testColection.Add(b);
			List<int> c = new List<int>() { 2, 6 };
			testColection.Add(c);
			Console.WriteLine("Result of IsTransversal() : {0} ",IsTransversal(testList,testColection));
			Console.Read();
		}

		public static bool IsTransversal(List<int> transversal, List<List<int>> family)
		{
			
			int count = 0;
			foreach (List<int> familyMember in family)
			{
				foreach (int expectedMember in transversal)
				{
					if (familyMember.Contains(expectedMember))
					{
						count++;
					}
				}
			}
			if (count == family.Count)
				return true;
			else
				return false;
		}

	}
}
