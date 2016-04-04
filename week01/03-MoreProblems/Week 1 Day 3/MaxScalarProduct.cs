using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Day_3
{
	//	Maximal Scalar Product

	//Implement the following function: 

	// int MaxScalarProduct(List<int> v1, List<int> v2) .

	//You are given two vectors -  v1 and  v2.A scalar product of two vectors is the following:
	//v1 = {a1, a2, ..., an}
	//
	//v2 = {b1, b2, ..., bn}

	//The scalar product is written as:
	//v1.v2 = a1* b1 + a2* b2 + ... + an* bn


	//Find a permutation of  v1 and a permutation of v2  for which their scalar product is the largest possible

	class MaxScalarProductClass
	{
		static int MaxScalarProduct(List<int> v1, List<int> v2)
		{
			int result = 0;
			if (v1.Count != v1.Count)
			{
				throw new ArgumentException();
			}
			v1.Sort();
			v2.Sort();
			for (int i = 0; i < v1.Count; i++)
			{
				result = v1[i] * v2[i];
			}
			return result;
		}
	}

}
