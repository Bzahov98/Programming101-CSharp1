using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_an_URL
{
	public class Decoder
	//Function which decodes a given URL following these rules:

	//%20=>' ' %3A=>':' %3D=>'?' %2F=>'/'

	//Input 'kitten%20pic.jpg' Output 'kitten pic.jpg'
	{
		Dictionary<string,string> dictionary = new Dictionary<string, string>()
		{
			{"%20"," "},
			{"%3A",":"},
			{"%3D","?"},
			{"%2F","/"},
		};

		public string DecodeUrl(string input)
		{
			StringBuilder builder = new StringBuilder(input);
			foreach (var V in dictionary)
			{
				builder.Replace(V.Key, V.Value);
			}
			return builder.ToString();
		}
	}
}
