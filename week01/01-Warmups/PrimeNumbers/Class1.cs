using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
	public class Prime
	{
		public static bool IsPrime(int number)
		{
			for (var i = 2; i < number; i++)
			{
				if (number%i == 0)
				{
					return false;
				}
			}

			return true;
		}

		public List<int> ListFirstPrimes(int number)
		{
			List<int> primesList = new List<int>();
			for (int i = 0; i < number; i++)
			{
				if (IsPrime(i))
				{
					primesList.Add(i);
				}
			}

			return primesList;
		}

}
}
