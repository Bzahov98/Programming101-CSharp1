using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Bombing
{
/*You are given a  NxM  matrix of integer numbers.

We can drop a bomb at any place in the matrix, which has the following effect:
•All of the 3 to 8 neighbours (depending on where you hit!) 
of the target are reduced by the value of the target.
•Numbers can be reduced only to 0 - they cannot go to negative.

For example, if we have the following matrix:
10 10 10
10  9  10
10 10 10


and we drop bomb at  9 , this will result in the following matrix:
1 1 1
1 9 1
1 1 1


Implement a function called  int MatrixBombing(int[,] m) .

The function should return the maximum damage we can inflict by 
bombing a single cell. The damage in each cell is calculated as 
the difference between the old value and value after bombing.

For example if we have the following matrix:
1 2  3  4
5 6  7  8
9 10 11 12

and run the function, we will have :  43  - the damage if we bomb at  7 */
	public class Program
	{
		static void Main(string[] args)
		{
			int[,] a = new int[3,4] { { 1, 2, 3, 4 }, { 5, 6, 7 ,8 }, { 9, 10 , 11 , 12 }};
			Console.WriteLine(MatrixBombing(a)); // expected 43

		}

		public static int MatrixBombing(int[,] m)
		{
			int rows = m.GetLength(0);
			int cols = m.GetLength(1);

			int maxDamage = 0;

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					int curDamage = 0;

					for (int k = row - 1; k <= row + 1; k++)
					{
						for (int l = col - 1; l <= col + 1; l++)
						{
							if (k != row || l != col)
							{
								try
								{
									curDamage += m[row, col] < m[k, l] ? m[row, col] : m[k, l];
								}
								catch (IndexOutOfRangeException exp)
								{
									Console.WriteLine(exp.Message);
								}
							}
						}
					}

					if (maxDamage < curDamage)
					{
						maxDamage = curDamage;
					}
				}
			}

			return maxDamage;
		}
	}
}
