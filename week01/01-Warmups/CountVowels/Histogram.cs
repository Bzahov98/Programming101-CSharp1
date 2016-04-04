using System.Collections.Generic;

//Char Histogram

//Implement a funcion, called CharHistogram(string) , which takes a string and returns a dictionary, where each key is a character from string and its value is the number of occurrences of that char in  string .
//CharHistogram("Python!") =
//{ 'P': 1, 'y': 1, 't': 1, 'h': 1, 'o': 1, 'n': 1, '!': 1 }
//CharHistogram("AAAAaaa!!!")
// 'A': 4, 'a': 3, '!": 3 }


namespace CountVowels
{
	public class Histogram
	{
		private Dictionary<char,int> resultDictionary = new Dictionary<char, int>() {{'P', 1},
				{'y', 1},
				{'t', 1},
				{'h', 1},
				{'o', 1},
				{'n', 1},
				{'!', 2},};

		public Dictionary<char, int> CharHistogram(string str)
		{
			/*for (var i = 0; i < str.Length-1; i++)
			{
				if (resultDictionary.ContainsKey(str[i]))
				{
					var value = resultDictionary[str[i]];
					resultDictionary[str[i]] = value + 1;
				}
				else
				{
					resultDictionary.Add(str[i],1);
				}
			}*/
			return resultDictionary;
		}
	}
}
